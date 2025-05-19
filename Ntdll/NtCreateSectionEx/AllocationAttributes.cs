namespace Ntdll {
partial class NtCreateSectionEx {


public enum AllocationAttributes : uint {
 SEC_IMAGE            = 0x01000000,
 SEC_RESERVE          = 0x04000000,
 SEC_COMMIT           = 0x08000000,
 SEC_NOCACHE          = 0x10000000,
 SEC_IMAGE_NO_EXECUTE = 0x11000000,
 SEC_WRITECOMBINE     = 0x40000000,
 SEC_LARGE_PAGES      = 0x80000000
}


} }