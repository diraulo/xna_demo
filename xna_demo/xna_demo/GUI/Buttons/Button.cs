using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace xna_demo.GUI.Buttons
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Button
    {
        bool mouseHover = false;
        
        Texture2D m_texture, m_textureHover;
        Vector2 m_position;

        Rectangle collisionRectangle;   

        public Button(Texture2D texture, Texture2D textureHover, Vector2 pos)
        {
            this.m_texture = texture;
            this.m_textureHover = textureHover;
            this.m_position = pos;
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public virtual void Update(GameTime gameTime)
        {
            //Collision Rectangle for the button
            collisionRectangle = new Rectangle((int)m_position.X, (int)m_position.Y,
                                m_texture.Width, m_texture.Height);

            MouseState mouse = Mouse.GetState();
            Rectangle mousePosition = new Rectangle(mouse.X, mouse.Y, 1, 1);

            if (mousePosition.Intersects(collisionRectangle))
                mouseHover = true;
            else
                mouseHover = false;

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (mouseHover)
                spriteBatch.Draw(m_textureHover, m_position, Color.White);
            else
                spriteBatch.Draw(m_texture, m_position, Color.White);
        }
    }
}
