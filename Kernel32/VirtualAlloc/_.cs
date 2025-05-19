using System.Runtime.InteropServices;
namespace Kernel32 {
partial class VirtualAlloc {


public static ulong _(
 ulong                     address        = SystemDeterminedAllocationAddress                     ,
 ulong                     size           = 1 * PageGranularity                                   ,
 AllocationType            allocationType = AllocationType.MEM_COMMIT | AllocationType.MEM_RESERVE,
 MemoryProtectionConstants protect        = MemoryProtectionConstants.PAGE_READONLY
) {
 return __(address, size, allocationType, protect);
}

[DllImport("kernel32.dll", EntryPoint="VirtualAlloc")] static extern ulong __(
 ulong                     address       ,
 ulong                     size          ,
 AllocationType            allocationType,
 MemoryProtectionConstants protect
);


} }