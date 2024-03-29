﻿using System;

using Microsoft.Extensions.Logging;

using R5T.Code.VisualStudio;
using R5T.Code.VisualStudio.IO;

using R5T.T0064;


namespace R5T.Tools.Dotnet
{
    [ServiceImplementationMarker]
    public class DotnetCommandSolutionFileActionServicesProvider : ISolutionFileActionServicesProvider, IServiceImplementation
    {
        private ILogger Logger { get; }


        public DotnetCommandSolutionFileActionServicesProvider(ILogger<DotnetCommandSolutionFileActionServicesProvider> logger)
        {
            this.Logger = logger;
        }

        public void AddProject(SolutionFilePath solutionFilePath, ProjectFilePath projectFilePath)
        {
            DotnetCommandServicesProvider.AddProjectFileToSolutionFile(solutionFilePath, projectFilePath, this.Logger);
        }

        public void RemoveProject(SolutionFilePath solutionFilePath, ProjectFilePath projectFilePath)
        {
            DotnetCommandServicesProvider.RemoveProjectFileFromSolutionFile(solutionFilePath, projectFilePath, this.Logger);
        }

        public void CreateSolutionFile(SolutionFilePath solutionFilePath)
        {
            DotnetCommandServicesProvider.CreateSolutionFile(solutionFilePath, this.Logger);
        }
    }
}
