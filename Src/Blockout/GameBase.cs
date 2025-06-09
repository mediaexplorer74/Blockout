// *************************************************************
// Type: Blockout.Game1
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace Blockout
{
    public class GameBase : Game
    {
        internal static GameInstance Instance;

        public virtual GameplayScreenBase CreateGameplayScreen()
        {
            return default;
        }

        public virtual void AddScreenTypeNameMapping(Dictionary<Type, string> screensNameMapping)
        {
        }

        public virtual void SerializeState()
        {
            //
        }

        public virtual bool DeserializeState()
        {
            return default;
        }

        public virtual void SerializeGameplay()
        {
            //
        }

        public virtual void DeserializeGameplay()
        {
            //
        }

        public virtual int GetBestSolution(int challangeIndex, int levelIndex)
        {
            return default;
        }

        public virtual bool IsAnyGameplyScreenType(Type screenType)
        {
            return default;
        }

        public virtual void HandleGuiInput(InputState input)
        {
        }

        public virtual MenuScreen GetPuzzleScreen() 
        {
            return default;
        }

        public virtual MenuScreen GetAchievementScreen()
        {
            return default;
        }

        public virtual PlatformInheritBase CreatePlatformInheritClass()
        {
            return default;
        }

        protected virtual bool DeserializeStateBackup()
        {
            return false;
        }

        protected virtual void DrawNormalScaledStuff()
        {
            //
        }
    }
}