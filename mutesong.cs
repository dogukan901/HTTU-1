﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace HTTU
{
    class mutesong
    {

        public static bool mute(SoundPlayer player, bool playerstate)
        {
            
            if (playerstate)
            {
                player.Stop();
               return playerstate = false;
            }
            else
            {
                player.Play();
               return playerstate = true;
            }

        }

    }
}
