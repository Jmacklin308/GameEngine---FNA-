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
    public class GameObject
    {
        //NOTE: protected - all classes that is a GameObject will have access to "image". Other classes won't.
        protected Texture2D image;
        public Vector2 position;
        public Color drawColor;
        public float scale = 1f;
        public float rotation = 0f;
        public float layerDepth = .5f;
        public bool active;
        protected Vector2 center;
        
        
        //Constructor
        public GameObject()
        {
            
        }

        //NOTE: Virtual functions are able to be overriden
        public virtual void Initialize()
        {
            
        }

        public virtual void Load(ContentManager content)
        {
            CalculateCenter();
            
        }

        public virtual void Update(List<GameObject> objects)
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if(image != null && active == true)
                spriteBatch.Draw(image,position,null,drawColor,rotation,center,scale,SpriteEffects.None,layerDepth);
        }

        private void CalculateCenter()
        {
            if(image == null)
                return;

            center.X = image.Width / 2.0f;
            center.Y = image.Height / 2.0f;
        }

    }
}