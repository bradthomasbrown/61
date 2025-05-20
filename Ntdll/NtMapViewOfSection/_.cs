using System.Runtime.InteropServices;
namespace Ntdll {
partial class NtMapViewOfSection {


public static uint _(
 uint               section            = 0                           ,
 uint               process            = uint.MaxValue               ,
 ulong              baseAddress        = 0                           ,
 ulong              zeroBits           = 0                           ,
 ulong              commitSize         = 0                           ,
 ulong              sectionOffset      = 0                           ,
 ulong              viewSize           = 0                           ,
 InheritDisposition inheritDisposition = InheritDisposition.ViewUnmap,
 AllocationType     allocationType     = 0                           ,
 PageProtection     pageProtection     = PageProtection.PAGE_READONLY
) {
 return __(
  section           ,
  process           ,
  baseAddress       ,
  zeroBits          ,
  commitSize        ,
  sectionOffset     ,
  viewSize          ,
  inheritDisposition,
  allocationType    ,
  pageProtection
 );
}

[DllImport("ntdll.dll", EntryPoint="NtMapViewOfSection")] static extern uint __(
 uint               section           ,
 uint               process           ,
 ulong              baseAddress       ,
 ulong              zeroBits          ,
 ulong              commitSize        ,
 ulong              sectionOffset     ,
 ulong              viewSize          ,
 InheritDisposition inheritDisposition,
 AllocationType     allocationType    ,
 PageProtection     pageProtection 
);


} }