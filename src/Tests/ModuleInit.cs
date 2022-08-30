public class ModuleInit
{
    #region enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifyPhash.Initialize();

        #endregion

        VerifyDiffPlex.Initialize();
    }
}