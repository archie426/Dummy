﻿using Cysharp.Threading.Tasks;
using EvolutionPlugins.Dummy.API;
using EvolutionPlugins.Dummy.Extensions;
using EvolutionPlugins.Dummy.Models.Users;
using OpenMod.Core.Commands;
using OpenMod.Unturned.Users;
using System;

namespace EvolutionPlugins.Dummy.Commands
{
    [Command("tphere")]
    [CommandDescription("Teleport to you a dummy")]
    [CommandActor(typeof(UnturnedUser))]
    [CommandSyntax("<id>")]
    [CommandParent(typeof(CommandDummy))]
    public class CommandDummyTphere : CommandDummyAction
    {
        public CommandDummyTphere(IServiceProvider serviceProvider, IDummyProvider dummyProvider) : base(serviceProvider, dummyProvider)
        {
        }

        protected override UniTask ExecuteDummyAsync(DummyUser playerDummy)
        {
            return playerDummy.TeleportToPlayerAsync((UnturnedUser)Context.Actor);
        }
    }
}
