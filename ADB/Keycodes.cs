using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADBScuffedMirroring.ADB;
public class Keycodes
{
    public static AndroidKeys GetKeycode(Keys code)
    {
        // was told that this was the best way to do it...
        // I don't believe them but I'll do it for now anyway because I don't know any other way.
        Console.WriteLine(code);
        switch (code)
        {
            case Keys.None: return AndroidKeys.KEYCODE_UNKNOWN;
            case Keys.LButton: return AndroidKeys.KEYCODE_BUTTON_1;
            case Keys.RButton: return AndroidKeys.KEYCODE_BUTTON_2;
            case Keys.MButton: return AndroidKeys.KEYCODE_BUTTON_3;
            case Keys.Back: return AndroidKeys.KEYCODE_DEL;
            case Keys.Tab: return AndroidKeys.KEYCODE_TAB;
            case Keys.LineFeed: return AndroidKeys.KEYCODE_ENTER;
            case Keys.Clear: return AndroidKeys.KEYCODE_CLEAR;
            case Keys.Enter: return AndroidKeys.KEYCODE_ENTER;
            case Keys.ShiftKey:
            case Keys.Shift:
            case Keys.LShiftKey: return AndroidKeys.KEYCODE_SHIFT_LEFT;
            case Keys.RShiftKey: return AndroidKeys.KEYCODE_SHIFT_RIGHT;
            case Keys.ControlKey:
            case Keys.Control:
            case Keys.LControlKey: return AndroidKeys.KEYCODE_CTRL_LEFT;
            case Keys.RControlKey: return AndroidKeys.KEYCODE_CTRL_RIGHT;
            case Keys.Alt:
            case Keys.Menu: return AndroidKeys.KEYCODE_ALT_LEFT;
            case Keys.Pause: return AndroidKeys.KEYCODE_BREAK;
            case Keys.CapsLock: return AndroidKeys.KEYCODE_CAPS_LOCK;
            case Keys.Escape: return AndroidKeys.KEYCODE_ESCAPE;
            case Keys.Space: return AndroidKeys.KEYCODE_SPACE;
            case Keys.PageUp: return AndroidKeys.KEYCODE_PAGE_UP;
            case Keys.PageDown: return AndroidKeys.KEYCODE_PAGE_DOWN;
            case Keys.End: return AndroidKeys.KEYCODE_MOVE_END;
            case Keys.Home: return AndroidKeys.KEYCODE_MOVE_HOME;
            case Keys.Left: return AndroidKeys.KEYCODE_DPAD_LEFT;
            case Keys.Up: return AndroidKeys.KEYCODE_DPAD_UP;
            case Keys.Right: return AndroidKeys.KEYCODE_DPAD_RIGHT;
            case Keys.Down: return AndroidKeys.KEYCODE_DPAD_DOWN;
            case Keys.Select: return AndroidKeys.KEYCODE_BUTTON_SELECT;
            case Keys.Execute: return AndroidKeys.KEYCODE_SEARCH;
            case Keys.PrintScreen: return AndroidKeys.KEYCODE_SYSRQ;
            case Keys.Insert: return AndroidKeys.KEYCODE_INSERT;
            case Keys.Delete: return AndroidKeys.KEYCODE_FORWARD_DEL;
            case Keys.Help: return AndroidKeys.KEYCODE_HELP;
            case Keys.D0: return AndroidKeys.KEYCODE_0;
            case Keys.D1: return AndroidKeys.KEYCODE_1;
            case Keys.D2: return AndroidKeys.KEYCODE_2;
            case Keys.D3: return AndroidKeys.KEYCODE_3;
            case Keys.D4: return AndroidKeys.KEYCODE_4;
            case Keys.D5: return AndroidKeys.KEYCODE_5;
            case Keys.D6: return AndroidKeys.KEYCODE_6;
            case Keys.D7: return AndroidKeys.KEYCODE_7;
            case Keys.D8: return AndroidKeys.KEYCODE_8;
            case Keys.D9: return AndroidKeys.KEYCODE_9;
            case Keys.A: return AndroidKeys.KEYCODE_A;
            case Keys.B: return AndroidKeys.KEYCODE_B;
            case Keys.C: return AndroidKeys.KEYCODE_C;
            case Keys.D: return AndroidKeys.KEYCODE_D;
            case Keys.E: return AndroidKeys.KEYCODE_E;
            case Keys.F: return AndroidKeys.KEYCODE_F;
            case Keys.G: return AndroidKeys.KEYCODE_G;
            case Keys.H: return AndroidKeys.KEYCODE_H;
            case Keys.I: return AndroidKeys.KEYCODE_I;
            case Keys.J: return AndroidKeys.KEYCODE_J;
            case Keys.K: return AndroidKeys.KEYCODE_K;
            case Keys.L: return AndroidKeys.KEYCODE_L;
            case Keys.M: return AndroidKeys.KEYCODE_M;
            case Keys.N: return AndroidKeys.KEYCODE_N;
            case Keys.O: return AndroidKeys.KEYCODE_O;
            case Keys.P: return AndroidKeys.KEYCODE_P;
            case Keys.Q: return AndroidKeys.KEYCODE_Q;
            case Keys.R: return AndroidKeys.KEYCODE_R;
            case Keys.S: return AndroidKeys.KEYCODE_S;
            case Keys.T: return AndroidKeys.KEYCODE_T;
            case Keys.U: return AndroidKeys.KEYCODE_U;
            case Keys.V: return AndroidKeys.KEYCODE_V;
            case Keys.W: return AndroidKeys.KEYCODE_W;
            case Keys.X: return AndroidKeys.KEYCODE_X;
            case Keys.Y: return AndroidKeys.KEYCODE_Y;
            case Keys.Z: return AndroidKeys.KEYCODE_Z;
            case Keys.LWin: return AndroidKeys.KEYCODE_META_LEFT;
            case Keys.RWin: return AndroidKeys.KEYCODE_META_RIGHT;
            case Keys.Apps: return AndroidKeys.KEYCODE_MENU;
            case Keys.Sleep: return AndroidKeys.KEYCODE_SLEEP;
            case Keys.NumPad0: return AndroidKeys.KEYCODE_NUMPAD_0;
            case Keys.NumPad1: return AndroidKeys.KEYCODE_NUMPAD_1;
            case Keys.NumPad2: return AndroidKeys.KEYCODE_NUMPAD_2;
            case Keys.NumPad3: return AndroidKeys.KEYCODE_NUMPAD_3;
            case Keys.NumPad4: return AndroidKeys.KEYCODE_NUMPAD_4;
            case Keys.NumPad5: return AndroidKeys.KEYCODE_NUMPAD_5;
            case Keys.NumPad6: return AndroidKeys.KEYCODE_NUMPAD_6;
            case Keys.NumPad7: return AndroidKeys.KEYCODE_NUMPAD_7;
            case Keys.NumPad8: return AndroidKeys.KEYCODE_NUMPAD_8;
            case Keys.NumPad9: return AndroidKeys.KEYCODE_NUMPAD_9;
            case Keys.Multiply: return AndroidKeys.KEYCODE_NUMPAD_MULTIPLY;
            case Keys.Add: return AndroidKeys.KEYCODE_NUMPAD_ADD;
            case Keys.Separator: return AndroidKeys.KEYCODE_NUMPAD_COMMA;
            case Keys.Subtract: return AndroidKeys.KEYCODE_NUMPAD_SUBTRACT;
            case Keys.Decimal: return AndroidKeys.KEYCODE_NUMPAD_DOT;
            case Keys.Divide: return AndroidKeys.KEYCODE_NUMPAD_DIVIDE;
            case Keys.F1: return AndroidKeys.KEYCODE_F1;
            case Keys.F2: return AndroidKeys.KEYCODE_F2;
            case Keys.F3: return AndroidKeys.KEYCODE_F3;
            case Keys.F4: return AndroidKeys.KEYCODE_F4;
            case Keys.F5: return AndroidKeys.KEYCODE_F5;
            case Keys.F6: return AndroidKeys.KEYCODE_F6;
            case Keys.F7: return AndroidKeys.KEYCODE_F7;
            case Keys.F8: return AndroidKeys.KEYCODE_F8;
            case Keys.F9: return AndroidKeys.KEYCODE_F9;
            case Keys.F10: return AndroidKeys.KEYCODE_F10;
            case Keys.F11: return AndroidKeys.KEYCODE_F11;
            case Keys.F12: return AndroidKeys.KEYCODE_F12;
            case Keys.NumLock: return AndroidKeys.KEYCODE_NUM_LOCK;
            case Keys.Scroll: return AndroidKeys.KEYCODE_SCROLL_LOCK;
            case Keys.OemSemicolon: return AndroidKeys.KEYCODE_SEMICOLON;
            case Keys.Oemplus: return AndroidKeys.KEYCODE_EQUALS;
            case Keys.Oemcomma: return AndroidKeys.KEYCODE_COMMA;
            case Keys.OemMinus: return AndroidKeys.KEYCODE_MINUS;
            case Keys.OemPeriod: return AndroidKeys.KEYCODE_PERIOD;
            case Keys.OemQuestion: return AndroidKeys.KEYCODE_SLASH;
            case Keys.Oemtilde: return AndroidKeys.KEYCODE_GRAVE;
            case Keys.OemOpenBrackets: return AndroidKeys.KEYCODE_LEFT_BRACKET;
            case Keys.OemPipe: return AndroidKeys.KEYCODE_BACKSLASH;
            case Keys.OemCloseBrackets: return AndroidKeys.KEYCODE_RIGHT_BRACKET;
            case Keys.OemQuotes: return AndroidKeys.KEYCODE_APOSTROPHE;
            case Keys.OemBackslash: return AndroidKeys.KEYCODE_BACKSLASH;
            case Keys.Play: return AndroidKeys.KEYCODE_MEDIA_PLAY;
            case Keys.OemClear: return AndroidKeys.KEYCODE_CLEAR;
            case Keys.BrowserBack: return AndroidKeys.KEYCODE_BACK;
            case Keys.BrowserForward: return AndroidKeys.KEYCODE_FORWARD;
            case Keys.BrowserSearch: return AndroidKeys.KEYCODE_SEARCH;
            case Keys.BrowserFavorites: return AndroidKeys.KEYCODE_BOOKMARK;
            case Keys.BrowserHome: return AndroidKeys.KEYCODE_HOME;
            case Keys.VolumeMute: return AndroidKeys.KEYCODE_VOLUME_MUTE;
            case Keys.VolumeDown: return AndroidKeys.KEYCODE_VOLUME_DOWN;
            case Keys.VolumeUp: return AndroidKeys.KEYCODE_VOLUME_UP;
            case Keys.MediaNextTrack: return AndroidKeys.KEYCODE_MEDIA_NEXT;
            case Keys.MediaPreviousTrack: return AndroidKeys.KEYCODE_MEDIA_PREVIOUS;
            case Keys.MediaStop: return AndroidKeys.KEYCODE_MEDIA_STOP;
            case Keys.MediaPlayPause: return AndroidKeys.KEYCODE_MEDIA_PLAY_PAUSE;
            case Keys.SelectMedia: return AndroidKeys.KEYCODE_MEDIA_RECORD;
            case Keys.Oem8:
            case Keys.ProcessKey:
            case Keys.Packet:
            case Keys.Attn:
            case Keys.Crsel:
            case Keys.Exsel:
            case Keys.EraseEof:
            case Keys.Zoom:
            case Keys.NoName:
            case Keys.Pa1:
            default: return AndroidKeys.KEYCODE_UNKNOWN;
        }
    }
}
