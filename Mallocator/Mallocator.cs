using Kernel32;
public class Mallocator {


public ulong Free;
public ulong Init;

public Mallocator(
 ulong                                  size    = 1 * VirtualAlloc.PageGranularity                     ,
 VirtualAlloc.MemoryProtectionConstants protect = VirtualAlloc.MemoryProtectionConstants.PAGE_READWRITE
) {
 Init = VirtualAlloc._(
  size    : size   ,
  protect : protect
 );
 Free = Init;
}

public ulong Alloc(uint size, uint align=1) {
 Free = Algorithms._e7_(Free, align);
 ulong pf = Free;
 Free = Free + size;
 return pf;
}


}