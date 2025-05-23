namespace Kernel32 {
partial class VirtualAlloc {


public enum AllocationType : uint {
 MEM_COMMIT      = 0x00001000,
 MEM_RESERVE     = 0x00002000,
 MEM_RESET       = 0x00080000,
 MEM_TOP_DOWN    = 0x00100000,
 MEM_WRITE_WATCH = 0x00200000,
 MEM_PHYSICAL    = 0x00400000,
 MEM_RESET_UNDO  = 0x10000000,
 MEM_LARGE_PAGES = 0x20000000
}


} }