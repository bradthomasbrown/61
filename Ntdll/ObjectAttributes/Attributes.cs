namespace Ntdll {
partial class ObjectAttributes {


public enum Attributes : uint {
 OBJ_PROTECT_CLOSE                 = 0x00000001,
 OBJ_INHERIT                       = 0x00000002,
 OBJ_AUDIT_OBJECT_CLOSE            = 0x00000004,
 OBJ_NO_RIGHTS_UPGRADE             = 0x00000008,
 OBJ_PERMANENT                     = 0x00000010,
 OBJ_EXCLUSIVE                     = 0x00000020,
 OBJ_CASE_INSENSITIVE              = 0x00000040,
 OBJ_OPENIF                        = 0x00000080,
 OBJ_OPENLINK                      = 0x00000100,
 OBJ_KERNEL_HANDLE                 = 0x00000200,
 OBJ_FORCE_ACCESS_CHECK            = 0x00000400,
 OBJ_IGNORE_IMPERSONATED_DEVICEMAP = 0x00000800,
 OBJ_DONT_REPARSE                  = 0x00001000
}


} }