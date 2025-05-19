using System.IO;
using Kernel32;
using Ntdll;
partial class _84_ {
 

unsafe public static ulong _72_(Mallocator m, string path) {
 ulong objectAttributes = ObjectAttributes.FromPath(m, path);
 ulong ioStatusBlock = m.Alloc(0x10, 8);
 uint file;
 NtOpenFile._(
  file             : (ulong)&file    ,
  objectAttributes : objectAttributes,
  ioStatusBlock    : ioStatusBlock
 );
 ulong noMaxSize = 0;
 uint section;
 NtCreateSectionEx._(
  section          : (ulong)&section  ,
  maximumSize      : (ulong)&noMaxSize,
  file             : file
 );
 ulong viewSize = (ulong)new FileInfo(path).Length;
 ulong baseAddress = 0;
 NtMapViewOfSection._(
  section       : section              ,
  baseAddress   : (ulong)&baseAddress  ,
  viewSize      : (ulong)&viewSize
 );
 return baseAddress;
}


}