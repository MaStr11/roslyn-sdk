﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using EnvDTE;

public class RoslynSDKVsixTemplateWizardThirdProject : RoslynSDKTestTemplateWizard
{
    public override void OnProjectFinishedGenerating(Project project)
    {
        base.OnProjectFinishedGenerating(project);

        // set the VSIX project to be the starting project
        var dte = project.DTE;
        if (dte.Solution.Projects.Count == 3)
        {
            dte.Solution.Properties.Item("StartupProject").Value = project.Name;
        }
    }
}
