﻿using System;

using Filter = System.UInt16;

namespace InputInterceptorNS
{

    public enum KeyCode : UInt16
    {
        Escape = 1,
        One = 2,
        Two = 3,
        Three = 4,
        Four = 5,
        Five = 6,
        Six = 7,
        Seven = 8,
        Eight = 9,
        Nine = 10,
        Zero = 11,
        Dash = 12,
        Equals = 13,
        Backspace = 14,
        Tab = 15,
        Q = 16,
        W = 17,
        E = 18,
        R = 19,
        T = 20,
        Y = 21,
        U = 22,
        I = 23,
        O = 24,
        P = 25,
        OpenBracketBrace = 26,
        CloseBracketBrace = 27,
        Enter = 28,
        NumpadEnter = 28,
        Control = 29,
        A = 30,
        S = 31,
        D = 32,
        F = 33,
        G = 34,
        H = 35,
        J = 36,
        K = 37,
        L = 38,
        Semicolon = 39,
        Apostrophe = 40,
        Tilde = 41,
        LeftShift = 42,
        Backslash = 43,
        Z = 44,
        X = 45,
        C = 46,
        V = 47,
        B = 48,
        N = 49,
        M = 50,
        Comma = 51,
        Dot = 52,
        Slash = 53,
        NumpadDivide = 53,
        RightShift = 54,
        PrintScreen = 55,
        NumpadAsterisk = 55,
        Alt = 56,
        Space = 57,
        CapsLock = 58,
        F1 = 59,
        F2 = 60,
        F3 = 61,
        F4 = 62,
        F5 = 63,
        F6 = 64,
        F7 = 65,
        F8 = 66,
        F9 = 67,
        F10 = 68,
        NumLock = 69,
        ScrollLock = 70,
        Home = 71,
        Numpad7 = 71,
        Up = 72,
        Numpad8 = 72,
        PageUp = 73,
        Numpad9 = 73,
        NumpadMinus = 74,
        Left = 75,
        Numpad4 = 75,
        Numpad5 = 76,
        Right = 77,
        Numpad6 = 77,
        NumpadPlus = 78,
        End = 79,
        Numpad1 = 79,
        Down = 80,
        Numpad2 = 80,
        PageDown = 81,
        Numpad3 = 81,
        Insert = 82,
        Numpad0 = 82,
        Delete = 83,
        NumpadDelete = 83,
        F11 = 87,
        F12 = 88,
        LeftWindowsKey = 91,
        RightWindowsKey = 92,
        Menu = 93,
    }

    [Flags]
    public enum KeyState : UInt16
    {
        Down = 0x00,
        Up = 0x01,
        E0 = 0x02,
        E1 = 0x04,
        TermsrvSetLED = 0x08,
        TermsrvShadow = 0x10,
        TermsrvVKPacket = 0x20,
    }

    [Flags]
    public enum KeyboardFilter : Filter
    {
        None = 0x00,
        All = 0xFF,
        KeyDown = 0x01,
        KeyUp = 0x02,
        KeyE0 = 0x04,
        KeyE1 = 0x08,
        KeyTermsrvSetLED = 0x10,
        KeyTermsrvShadow = 0x20,
        KeyTermsrvVKPacket = 0x40,
    }

    [Flags]
    public enum MouseState : UInt16
    {
        LeftButtonDown = 0x001,
        LeftButtonUp = 0x002,
        RightButtonDown = 0x004,
        RightButtonUp = 0x008,
        MiddleButtonDown = 0x010,
        MiddleButtonUp = 0x020,
        ExtraButton1Down = 0x040,
        ExtraButton1Up = 0x080,
        ExtraButton2Down = 0x100,
        ExtraButton2Up = 0x200,
        ScrollVertical = 0x400,
        ScrollHorizontal = 0x800,
    }

    [Flags]
    public enum MouseFilter : Filter
    {
        None = 0x0000,
        All = 0xFFFF,
        LeftButtonDown = MouseState.LeftButtonDown,
        LeftButtonUp = MouseState.LeftButtonUp,
        RightButtonDown = MouseState.RightButtonDown,
        RightButtonUp = MouseState.RightButtonUp,
        MiddleButtonDown = MouseState.MiddleButtonDown,
        MiddleButtonUp = MouseState.MiddleButtonUp,
        ExtraButton1Down = MouseState.ExtraButton1Down,
        ExtraButton1Up = MouseState.ExtraButton1Up,
        ExtraButton2Down = MouseState.ExtraButton2Down,
        ExtraButton2Up = MouseState.ExtraButton2Up,
        ScrollVertical = MouseState.ScrollVertical,
        ScrollHorizontal = MouseState.ScrollHorizontal,
        Move = 0x1000,
    }

    [Flags]
    public enum MouseFlags : UInt16
    {
        MoveRelative = 0x000,
        MoveAbsolute = 0x001,
        VirtualDesktop = 0x002,
        AttributesChanged = 0x004,
        MoveWithoutCoalescing = 0x008,
        TerminalServicesSourceShadow = 0x100,
    }

}
