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
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public List<GameObject> objects = new List<GameObject>();

        public Game1() //This is the constructor, this function is called whenever the game class is created.
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            //set resolution and other display settings
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 780;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

        }


        protected override void Initialize()
        {
            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            LoadLevel();
            
        }


        protected override void Update(GameTime gameTime)
        {
            //keep input up to date
            Input.Update();
            
            UpdateObjects();
            
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            DrawObjects();
            spriteBatch.End();
            

            //Draw the things FNA handles for us underneath the hood:
            base.Draw(gameTime);
        }


        

        #region helper functions - Game objects
        
        
        public void LoadLevel()
        {
            //ADD ALL OBJECTS FOR LEVEL BELOW
            
            //add player to the level
            objects.Add(new Player(new Vector2(640,360)));
            
            
            //load all the objects
            LoadObjects();
        }
        
        
        
        public void LoadObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Initialize();
                objects[i].Load(Content);
            }
        }

        public void UpdateObjects()
        { 
            for (int i = 0; i < objects.Count; i++)
            {
                //all game objects have access to every other game object
                objects[i].Update(objects);
            }
        }

        public void DrawObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                //all game objects have access to every other game object
                objects[i].Draw(spriteBatch);
            }
        }
        
        #endregion

        
    }
}