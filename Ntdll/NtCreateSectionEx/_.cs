using System.Runtime.InteropServices;
namespace Ntdll {
partial class NtCreateSectionEx {


public static uint _(
 ulong                 section                = 0                              ,
 Access                access                 = Access.SECTION_MAP_READ        ,
 ulong                 objectAttributes       = 0                              ,
 ulong                 maximumSize            = 0                              ,
 PageProtection        pageProtection         = PageProtection.PAGE_READONLY   ,
 AllocationAttributes  allocationAttributes   = AllocationAttributes.SEC_COMMIT,
 uint                  file                   = 0                              ,
 ulong                 extendedParameters     = 0                              ,
 ulong                 extendedParameterCount = 0
) {
 return __(
  section               ,
  access                ,
  objectAttributes      ,
  maximumSize           ,
  pageProtection        ,
  allocationAttributes  ,
  file                  ,
  extendedParameters    ,
  extendedParameterCount
 );
}

[DllImport("ntdll.dll", EntryPoint="NtCreateSectionEx")] static extern uint __(
 ulong                section               ,
 Access               access                ,
 ulong                objectAttributes      ,
 ulong                maximumSize           ,
 PageProtection       pageProtection        ,
 AllocationAttributes allocationAttributes  ,
 uint                 file                  ,
 ulong                extendedParameters    ,
 ulong                extendedParameterCount
);


} }