﻿/*
 * Copyright (C) 2012 Interactive Lab
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the 
 * 
 */

using System;
using TouchScript.Gestures;

namespace TouchScript.Events {
    /// <summary>
    /// Gesture state change event arguments.
    /// </summary>
    public class GestureStateChangeEventArgs : EventArgs {
        public Gesture.GestureState PreviousState;
        public Gesture.GestureState State;

        public GestureStateChangeEventArgs(Gesture.GestureState state, Gesture.GestureState previousState) {
            State = state;
            PreviousState = previousState;
        }
    }
}