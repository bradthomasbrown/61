using System.Runtime.InteropServices;
namespace Ntdll {
partial class NtQueueApcThreadEx2 {


public static uint _(
 uint     thread     = CurrentThread                                 ,
 uint     reserve    = 0                                             ,
 ApcFlags apcFlags   = ApcFlags.QUEUE_USER_APC_FLAGS_SPECIAL_USER_APC,
 ulong    apcRoutine = 0                                             ,
 ulong    arg0       = 0                                             ,
 ulong    arg1       = 0                                             ,
 ulong    arg2       = 0
) {
 return __(
  thread    ,
  reserve   ,
  apcFlags  ,
  apcRoutine,
  arg0      ,
  arg1      ,
  arg2
 );
}

[DllImport("ntdll.dll", EntryPoint="NtQueueApcThreadEx2")] static extern uint __(
 uint     thread    ,
 uint     reserve   ,
 ApcFlags apcFlags  ,
 ulong    apcRoutine,
 ulong    arg0      ,
 ulong    arg1      ,
 ulong    arg2
);


} }