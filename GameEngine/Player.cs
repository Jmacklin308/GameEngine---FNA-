using System;
using System.Collections.Generic;
using System.Linq;
using GameEngine.Utilites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace GameEngine
{
    public class Player : GameObject
    {

        //constructor
        public Player()
        {
            
        }
        
        
        //assign position - constructor
        public Player(Vector2 inputPostion)
        {
            
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Load(ContentManager content)
        {
            //image = TextureLoader.Load("Ham/spr_player_idle_down_left_strip22.png",content);
            base.Load(content);
        }

        public override void Update(List<GameObject> objects)
        {
            CheckInput();
            base.Update(objects);
        }

        private void CheckInput()
        { 
            
        }
        
    }
}