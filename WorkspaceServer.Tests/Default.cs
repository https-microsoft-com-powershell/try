using System;
using System.Threading.Tasks;
using MLS.Agent.Tools;

namespace WorkspaceServer.Tests
{
    internal static class Default
    {
        private static readonly Lazy<Workspace> _templateWorkspace = new Lazy<Workspace>(() =>
        {
            var workspace = new Workspace("TestTemplate");
            Task.Run(() => workspace.EnsureCreated()).Wait();
            workspace.EnsureBuilt();
            return workspace;
        });

        public static Workspace TemplateWorkspace => _templateWorkspace.Value;
    }
}
