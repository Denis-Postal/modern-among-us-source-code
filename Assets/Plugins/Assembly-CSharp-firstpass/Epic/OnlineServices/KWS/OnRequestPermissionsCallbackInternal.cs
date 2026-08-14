using System.Runtime.InteropServices;

namespace Epic.OnlineServices.KWS
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnRequestPermissionsCallbackInternal(ref RequestPermissionsCallbackInfoInternal data);
}
