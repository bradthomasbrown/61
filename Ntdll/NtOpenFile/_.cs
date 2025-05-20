using System.Runtime.InteropServices;
namespace Ntdll {
partial class NtOpenFile {


public static uint _(
 ulong       file             = 0                                  ,
 Access      access           = Access.FILE_READ_DATA              ,
 ulong       objectAttributes = 0                                  ,
 ulong       ioStatusBlock    = 0                                  ,
 ShareAccess shareAccess      = 0                                  ,
 OpenOptions openOptions      = OpenOptions.FILE_NON_DIRECTORY_FILE
) {
 return __(
  file            ,
  access          ,
  objectAttributes,
  ioStatusBlock   ,
  shareAccess     ,
  openOptions
 );
}

[DllImport("ntdll.dll", EntryPoint="NtOpenFile")] static extern uint __(
 ulong       file            ,
 Access      access          ,
 ulong       objectAttributes,
 ulong       maximumSize     ,
 ShareAccess shareAccess     ,
 OpenOptions openOptions
);


} }