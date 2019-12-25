using System;
using System.Runtime.InteropServices;

namespace Interop
{
	internal static class NativeMethods
	{
		#region General Definitions

		// Various helper constants
		internal static IntPtr NO_PARENT = IntPtr.Zero;

		// Various important window messages
		internal const int WM_USER = 0x0400;
		internal const int WM_ENTERIDLE = 0x0121;

		// FormatMessage constants and structs
		internal const int FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;

		#endregion


		#region File Operations Definitions
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 4)]
		internal struct COMDLG_FILTERSPEC
		{
			[MarshalAs(UnmanagedType.LPWStr)]
			internal string pszName;
			[MarshalAs(UnmanagedType.LPWStr)]
			internal string pszSpec;
		}

		internal enum FDAP
		{
			FDAP_BOTTOM = 0x00000000,
			FDAP_TOP = 0x00000001,
		}

		// wpffb used
		internal enum FDE_SHAREVIOLATION_RESPONSE
		{
			FDESVR_DEFAULT = 0x00000000,
			FDESVR_ACCEPT = 0x00000001,
			FDESVR_REFUSE = 0x00000002
		}

		//wpffb used
		internal enum FDE_OVERWRITE_RESPONSE
		{
			FDEOR_DEFAULT = 0x00000000,
			FDEOR_ACCEPT = 0x00000001,
			FDEOR_REFUSE = 0x00000002
		}

		internal enum SIATTRIBFLAGS
		{
			SIATTRIBFLAGS_AND = 0x00000001, // if multiple items and the attirbutes together.
			SIATTRIBFLAGS_OR = 0x00000002, // if multiple items or the attributes together.
			SIATTRIBFLAGS_APPCOMPAT = 0x00000003, // Call GetAttributes directly on the ShellFolder for multiple attributes
		}

		// wpffb used
		internal enum SIGDN : uint
		{
			SIGDN_NORMALDISPLAY = 0x00000000,           // SHGDN_NORMAL
			SIGDN_PARENTRELATIVEPARSING = 0x80018001,   // SHGDN_INFOLDER | SHGDN_FORPARSING
			SIGDN_DESKTOPABSOLUTEPARSING = 0x80028000,  // SHGDN_FORPARSING
			SIGDN_PARENTRELATIVEEDITING = 0x80031001,   // SHGDN_INFOLDER | SHGDN_FOREDITING
			SIGDN_DESKTOPABSOLUTEEDITING = 0x8004c000,  // SHGDN_FORPARSING | SHGDN_FORADDRESSBAR
			SIGDN_FILESYSPATH = 0x80058000,             // SHGDN_FORPARSING
			SIGDN_URL = 0x80068000,                     // SHGDN_FORPARSING
			SIGDN_PARENTRELATIVEFORADDRESSBAR = 0x8007c001,     // SHGDN_INFOLDER | SHGDN_FORPARSING | SHGDN_FORADDRESSBAR
			SIGDN_PARENTRELATIVE = 0x80080001           // SHGDN_INFOLDER
		}

		//wpffb used
		[Flags]
		internal enum FOS : uint
		{
			FOS_OVERWRITEPROMPT = 0x00000002,
			FOS_STRICTFILETYPES = 0x00000004,
			FOS_NOCHANGEDIR = 0x00000008,
			FOS_PICKFOLDERS = 0x00000020,
			FOS_FORCEFILESYSTEM = 0x00000040, // Ensure that items returned are filesystem items.
			FOS_ALLNONSTORAGEITEMS = 0x00000080, // Allow choosing items that have no storage.
			FOS_NOVALIDATE = 0x00000100,
			FOS_ALLOWMULTISELECT = 0x00000200,
			FOS_PATHMUSTEXIST = 0x00000800,
			FOS_FILEMUSTEXIST = 0x00001000,
			FOS_CREATEPROMPT = 0x00002000,
			FOS_SHAREAWARE = 0x00004000,
			FOS_NOREADONLYRETURN = 0x00008000,
			FOS_NOTESTFILECREATE = 0x00010000,
			FOS_HIDEMRUPLACES = 0x00020000,
			FOS_HIDEPINNEDPLACES = 0x00040000,
			FOS_NODEREFERENCELINKS = 0x00100000,
			FOS_DONTADDTORECENT = 0x02000000,
			FOS_FORCESHOWHIDDEN = 0x10000000,
			FOS_DEFAULTNOMINIMODE = 0x20000000
		}
		#endregion

		#region KnownFolder Definitions
		// Property System structs and consts
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		internal struct PROPERTYKEY
		{
			internal Guid fmtid;
			internal uint pid;
		}
		#endregion
	}

}

