using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;

namespace UndoBoss
{
    [ApiVersion(2, 1)]
    public class UndoBoss : TerrariaPlugin
    {
        public override string Author => "Ozz5581";

        public override string Description => "Undo Defeated Bosses";

        public override string Name => "UndoBoss";

        public override Version Version => new Version(1, 0, 0, 0);

        public UndoBoss(Main game) : base(game)
        {

        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("undoboss.use", UndoBossCommand, "undoboss", "uboss")
            {
                HelpText = "Undo Boss Command."
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Deregister hooks here
            }
            base.Dispose(disposing);
        }

        private static void UndoBossCommand(CommandArgs args)
        {
            string subcommand = args.Parameters.Count == 0 ? "uboss" : args.Parameters[0].ToLower();

            switch (subcommand)
            {
                case "kingslime":
                case "king":
                case "ks":
                    {
                        NPC.downedSlimeKing = !NPC.downedSlimeKing;
                        args.Player.SendInfoMessage($"Set King Slime as {(NPC.downedSlimeKing ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "eyeofcthulhu":
                case "eye":
                case "eoc":
                    {
                        NPC.downedBoss1 = !NPC.downedBoss1;
                        args.Player.SendInfoMessage($"Set Eye of Cthulhu as {(NPC.downedBoss1 ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "evilboss":
                case "boc":
                case "eow":
                case "eaterofworlds":
                case "brainofcthulhu":
                case "brain":
                case "eater":
                    {
                        NPC.downedBoss2 = !NPC.downedBoss2;
                        args.Player.SendInfoMessage($"Set {(WorldGen.crimson ? "Brain of Cthulhu" : "Eater of Worlds")} as {(NPC.downedBoss2 ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "skeletron":
                case "sans":
                    {
                        NPC.downedBoss3 = !NPC.downedBoss3;
                        args.Player.SendInfoMessage($"Set Skeletron as {(NPC.downedBoss3 ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "queenbee":
                case "qb":
                    {
                        NPC.downedQueenBee = !NPC.downedQueenBee;
                        args.Player.SendInfoMessage($"Set Queen Bee as {(NPC.downedQueenBee ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "hardmode":
                case "wallofflesh":
                    {
                        Main.hardMode = !Main.hardMode;
                        args.Player.SendInfoMessage($"Set Wall of Flesh (aka Hardmode) as {(Main.hardMode ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        args.Player.SendInfoMessage("Note: This is the same as the '/hardmode' command.");
                        return;
                    }
                case "mech1":
                case "thedestroyer":
                    {
                        NPC.downedMechBoss1 = !NPC.downedMechBoss1;
                        args.Player.SendInfoMessage($"Set The Destroyer as {(NPC.downedMechBoss1 ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "mech2":
                case "thetwins":
                    {
                        NPC.downedMechBoss2 = !NPC.downedMechBoss2;
                        args.Player.SendInfoMessage($"Set The Twins as {(NPC.downedMechBoss2 ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "mech3":
                case "skeletronprime":
                    {
                        NPC.downedMechBoss3 = !NPC.downedMechBoss3;
                        args.Player.SendInfoMessage($"Set Skeletron Prime as {(NPC.downedMechBoss3 ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "plantera":
                    {
                        NPC.downedPlantBoss = !NPC.downedPlantBoss;
                        args.Player.SendInfoMessage($"Set Plantera as {(NPC.downedPlantBoss ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "golem":
                    {
                        NPC.downedGolemBoss = !NPC.downedGolemBoss;
                        args.Player.SendInfoMessage($"Set Golem as {(NPC.downedGolemBoss ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "cultist":
                case "lunatic":
                    {
                        NPC.downedAncientCultist = !NPC.downedAncientCultist;
                        args.Player.SendInfoMessage($"Set Lunatic Cultist as {(NPC.downedAncientCultist ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "duke":
                case "fishron":
                    {
                        NPC.downedFishron = !NPC.downedFishron;
                        args.Player.SendInfoMessage($"Set Duke Fishron as {(NPC.downedFishron ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "empress":
                case "eol":
                case "empressoflight":
                    {
                        NPC.downedEmpressOfLight = !NPC.downedEmpressOfLight;
                        args.Player.SendInfoMessage($"Set Empress of Light as {(NPC.downedEmpressOfLight ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                case "moonlord":
                case "ml":
                    {
                        NPC.downedMoonlord = !NPC.downedMoonlord;
                        args.Player.SendInfoMessage($"Set Moonlord as {(NPC.downedMoonlord ? "[c/FF0000:Killed]" : "[c/00FF00:Not Killed]")}!");
                        return;
                    }
                default:
                    {
                        args.Player.SendErrorMessage("Please specify which boss to toggle!");
                        args.Player.SendInfoMessage("eg. /undoboss king - toggle king slime");
                        return;
                    }
            }

        }
    }
}