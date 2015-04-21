var clrmd = Require<ClrMdPack>();
var clrRuntime = clrmd.Attach(2772);
clrmd.DumpHeapStatsByType();
clrmd.Detach();