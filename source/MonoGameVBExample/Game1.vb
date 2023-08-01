Imports System.Runtime.CompilerServices
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class Game1
    Inherits Game

    Dim _graphics As GraphicsDeviceManager
    Dim _spriteBatch As SpriteBatch

    Sub New()
        _graphics = New GraphicsDeviceManager(Me)
        Content.RootDirectory = "Content"
        IsMouseVisible = True
    End Sub

    Protected Overrides Sub Initialize()
        'TODO: Add your initialization logic here
        MyBase.Initialize()
    End Sub

    Protected Overrides Sub LoadContent()
        _spriteBatch = New SpriteBatch(GraphicsDevice)
        'TODO use Me.Content to load your game content here
        MyBase.LoadContent()
    End Sub

    Protected Overrides Sub Update(gameTime As GameTime)
        If GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed Or Keyboard.GetState().IsKeyDown(Keys.Escape) Then
            Me.Exit()
        End If

        'TODO Add your update logic here

        MyBase.Update(gameTime)
    End Sub

    Protected Overrides Sub Draw(gameTime As GameTime)
        GraphicsDevice.Clear(Color.CornflowerBlue)

        'TODO: Add your drawing code here
        MyBase.Draw(gameTime)
    End Sub

End Class
