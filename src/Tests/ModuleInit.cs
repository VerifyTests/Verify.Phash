public class ModuleInit
{
    #region enable

    [ModuleInitializer]
    public static void Init() =>
        VerifyPhash.Initialize();

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}