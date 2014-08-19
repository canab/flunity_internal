using System;
using ActionLib.Unity;
using UnityEngine;
using System.Collections.Generic;
using ActionLib.Utils;

namespace ActionLib.Display
{
	/// <summary>
	/// Provides events to handle touches on target DisplayObject.
	/// Events will not be fired if target object or its parent is not enabled.
	/// </summary>
	public class TouchListener
	{
		/// <summary>
		/// Rect in local coordinates system which will react on events.
        /// If not specified, <c>DisplayObject.internalBounds</c> will be used
		/// </summary>
		public Rect? hitArea;

		private readonly DisplayObject _target;

		private readonly List<TouchState> _touches = new List<TouchState>();

		private FlashStage _stage;

		#region events

		/// <summary>
		/// Dispatches when object is touched.
		/// Will be dispatched several times in case of multitouch.
		/// </summary>
		public event Action<TouchListener, TouchState> TouchBegan;

		/// <summary>
		/// Dispatches when touch is ended.
		/// Will be dispatched several times in case of multitouch.
		/// </summary>
		public event Action<TouchListener, TouchState> TouchEnded;

		/// <summary>
		/// Dispatches when object is touched first time.
		/// Will be dispatched once in case of multitouch.
		/// </summary>
		public event Action<TouchListener> Pressed;

		/// <summary>
		/// Dispatches when all touches are ended.
		/// Will be dispatched once in case of multitouch.
		/// </summary>
		public event Action<TouchListener> Released;

		#endregion

		#region event helpers

		public TouchListener OnTouchBegan(Action<TouchListener, TouchState> handler)
		{
			TouchBegan += handler;
			return this;
		}

		public TouchListener OnTouchEnded(Action<TouchListener, TouchState> handler)
		{
			TouchEnded += handler;
			return this;
		}

		public TouchListener OnPressed(Action<TouchListener> handler)
		{
			Pressed += handler;
			return this;
		}

		public TouchListener OnReleased(Action<TouchListener> handler)
		{
			Released += handler;
			return this;
		}

		#endregion

		#region isPressed

		private bool _isPressed = false;

		public bool isPressed
		{
			get { return _isPressed; }

			private set
			{
				if (_isPressed == value)
					return;

				_isPressed = value;

				if (_isPressed)
					Pressed.Dispatch(this);
				else
					Released.Dispatch(this);
			}
		}
		#endregion

		public TouchListener(DisplayObject target)
		{
			_target = target;
			_target.AddedToStage += OnTargetAdded;
			_target.RemovedFromStage += OnTargetRemoved;

			if (_target.isOnStage)
				OnTargetAdded(target);
		}

		void OnTargetAdded(DisplayObject obj)
		{
			_stage = target.stage;
			_stage.input.TouchBegan += OnTouchBegan;
			_stage.input.TouchEnded += OnTouchEnded;

			if (Debug.isDebugBuild)
				_stage.drawEvent.AddListener(DrawDebugRect);
		}

		void OnTargetRemoved(DisplayObject obj)
		{
			_stage.input.TouchBegan -= OnTouchBegan;
			_stage.input.TouchEnded -= OnTouchEnded;

			if (Debug.isDebugBuild)
				_stage.drawEvent.RemoveListener(DrawDebugRect);

			_stage = null;
		}

		void DrawDebugRect()
		{
			if (DebugDraw.drawHitAreas && IsTouchEnabled())
			{
				var rect = hitArea.HasValue
					? hitArea.Value
					: target.GetInternalBounds();

				DebugDraw.DrawRect(target, rect, DebugDraw.drawHitAreasColor);
			}
		}

		void OnTouchBegan(TouchState touch)
		{
			if (!IsTouchEnabled())
				return;

			if (!HitTestPoint(touch.position))
				return;

			var touchIndex = GetTouchIndex(touch.id);
			if (touchIndex >= 0)
				return;

			_touches.Add(touch);
			TouchBegan.Dispatch(this, touch);
			isPressed = _touches.Count > 0;
		}

		void OnTouchEnded(TouchState touch)
		{
			if (!IsTouchEnabled())
			{
				_isPressed = false;
				_touches.Clear();
				return;
			}

			var touchIndex = GetTouchIndex(touch.id);
			if (touchIndex < 0)
				return;

			_touches.RemoveAt(touchIndex);
			TouchEnded.Dispatch(this, touch);
			isPressed = _touches.Count > 0;
		}

		private int GetTouchIndex(int touchId)
		{
			for (int i = 0; i < _touches.Count; i++)
			{
				if (_touches[i].id == touchId)
					return i;
			}
			return -1;
		}

		/// <summary>
		/// Returns true if touch area contains point specified in global coordinates.
		/// </summary>
		public bool HitTestPoint(Vector2 globalPoint)
		{
			var localBounds = hitArea.HasValue
				? hitArea.Value
				: target.GetInternalBounds();

			var localPoint = target.GlobalToLocal(globalPoint);

			return localBounds.Contains(localPoint);
		}

		bool IsTouchEnabled()
		{
			for (var t = target; t != null; t = t.parent)
			{
				if (!t.enabled || !t.visible)
					return false;
			}
			return true;
		}

		/// <summary>
		/// Returns all touches are active at the moment. Does not allocate memory.
		/// </summary>
		public ICollection<TouchState> touches
		{
			get { return _touches; }
		}

		public DisplayObject target
		{
			get { return _target; }
		}
	}
}

