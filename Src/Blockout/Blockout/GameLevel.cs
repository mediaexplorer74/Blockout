// *************************************************************
// Type: Blockout.GameLevel
// Assembly: Blockout, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A5FFAAE6-A6F2-4299-B64C-2405C1773121
// *************************************************************

//using GameFoundation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable
namespace Blockout
{
  [DataContract]
    public class GameLevel
    {
        private int texLevelIndex;
        private Rectangle posLevelPos;
        private Block[] blocks;
        private int namesID;
        private List<BlockMovement> blockMovementTracking;
        private Vector2[] lastBlockRasterPositions;
        private Vector2[] lastBlockPositions;

        // Existing code...

        public GameLevel(int texToUseIndex, Rectangle posToPlace, Block[] blocks)
        {
            if (texToUseIndex >= ClientTree.DisconnectProject(3872))
            {
            label_1:
                switch (4)
                {
                    case 0:
                        goto label_1;
                    default:
                        if (false)
                        {
                            // Removed problematic code causing CS0103
                            // RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.\u002Ector);
                        }
                        if (texToUseIndex >= (int)DeviceQueue.DisconnectProject(GameGenerator.texLevelNames))
                        {
                        label_5:
                            switch (2)
                            {
                                case 0:
                                    goto label_5;
                            }
                        }
                        else
                        {
                            this.texLevelIndex = texToUseIndex;
                            this.posLevelPos = posToPlace;
                            this.blocks = blocks;
                            this.namesID = ClientTree.DisconnectProject(3876);
                            this.blockMovementTracking = new List<BlockMovement>();
                            this.lastBlockRasterPositions = ViewInvoker.DisconnectProject((int)ConnectionContext.DisconnectProject(blocks));
                            for (int index = ClientTree.DisconnectProject(3880); index < (int)ConnectionContext.DisconnectProject(blocks); index += ClientTree.DisconnectProject(3884))
                                this.lastBlockRasterPositions[index] = new Vector2((float)blocks[index].ClosestRasterPosX, (float)blocks[index].ClosestRasterPosY);
                            label_10:
                            switch (7)
                            {
                                case 0:
                                    goto label_10;
                                default:
                                    this.lastBlockPositions = ViewInvoker.DisconnectProject((int)ConnectionContext.DisconnectProject(blocks));
                                    this.ListQueue();
                                    this.LoadContent();
                                    return;
                            }
                        }
                        break;
                }
            }
            throw new ArgumentNullException();
        }

        //TODO
        private void LoadContent()
        {
            throw new NotImplementedException();
        }

        internal void DisconnectProject(InputState _param1)
        {
            if (_param1 == null)
            {
            label_1:
                switch (5)
                {
                    case 0:
                        goto label_1;
                    default:
                        if (true)
                            break;
                        // Removed problematic code causing CS0103
                        // RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.DisconnectProject);
                        break;
                }
            }
            else
            {
                // Existing code...
            }
        }

        private void ListQueue()
        {
            for (int index = ClientTree.DisconnectProject(3860); index < (int)ConnectionContext.DisconnectProject(this.blocks); index += ClientTree.DisconnectProject(3864))
                this.lastBlockPositions[index] = new Vector2((float)this.blocks[index].pos.X, (float)this.blocks[index].pos.Y);
            label_3:
            switch (6)
            {
                case 0:
                    goto label_3;
                default:
                    if (true)
                        break;
                    // Removed problematic code causing CS0103
                    // RuntimeMethodHandle runtimeMethodHandle = __methodref (GameLevel.ListQueue);
                    break;
            }
        }
    }
}
