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


namespace xna_demo.GUI.Menus
{

    public class MainMenu
    {
        Texture2D background;
        Texture2D btnNewGame, btnExitGame;
        Texture2D btnNewGameH, btnExitGameH;

        GUI.Buttons.NewGameButton newGameBtn;
        GUI.Buttons.ExitGameButton exitGameBtn;

        public MainMenu(ContentManager Content)
        {
            background = Content.Load<Texture2D>(@"Sprites/GUI/background");
            btnNewGame = Content.Load<Texture2D>(@"Sprites/Buttons/new_game_btn");
            btnNewGameH = Content.Load<Texture2D>(@"Sprites/Buttons/new_game_btn_hover");
            btnExitGame = Content.Load<Texture2D>(@"Sprites/Buttons/exit_btn");
            btnExitGameH = Content.Load<Texture2D>(@"Sprites/Buttons/exit_btn_hover");

            newGameBtn = new Buttons.NewGameButton(btnNewGame, btnNewGameH, new Vector2((GameEngine.clientBoundaries.X - btnNewGame.Width) / 2, 100));
            exitGameBtn = new Buttons.ExitGameButton(btnExitGame, btnExitGameH, new Vector2((GameEngine.clientBoundaries.X - btnExitGame.Width) / 2, btnNewGame.Height + 200));
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Update(GameTime gameTime)
        {
            newGameBtn.Update(gameTime);
            exitGameBtn.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            newGameBtn.Draw(spriteBatch);
            exitGameBtn.Draw(spriteBatch);
        }
    }
}
