﻿using Dalamud.Plugin;

namespace Dalamud.Divination.Common.Boilerplate
{
    public class ExamplePlugin : DivinationPlugin<ExamplePlugin, EmptyConfig, EmptyDefinitionContainer>
    {
        public ExamplePlugin(DalamudPluginInterface pluginInterface) : base(pluginInterface)
        {
            Config = pluginInterface.GetPluginConfig() as EmptyConfig ?? new EmptyConfig();
        }

        public override EmptyConfig Config { get; }

        protected override void ReleaseManaged()
        {
            Dalamud.PluginInterface.SavePluginConfig(Config);
        }
    }
}
