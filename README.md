# MonoGame Visual Basic Example
This is an example of using MonoGame with VB.NET instead of c#.  This example uses the MonoGame Desktop GL Template.

Below you can find the step-by-step instructions on doing this manually if you would prefer instead of using this template.

## Step 1: Creating The Project
First create a new **Visual Basic Console Application** project.  Once the project has been created, edit the `.vbproj` file and change the `<OutputType>Exe</OutputType>` to `<OutputType>WinExe</OutputType>`

## Step 2: Creating Content Directory
Next, create a new directory in the project directory called `Content`.  Inside this directory create a new file called `Content.mgcb` and add the following boilerplate to the `Content.mgcb` file you just created

```
#----------------------------- Global Properties ----------------------------#

/outputDir:bin/$(Platform)
/intermediateDir:obj/$(Platform)
/platform:DesktopGL
/config:
/profile:Reach
/compress:False

#-------------------------------- References --------------------------------#


#---------------------------------- Content ---------------------------------#
```

## Step 3: Add Nuget References
Next, you will need to add the NuGet References.  The first is the `MonoGame.Content.Builder.Task` NuGet.  This is absolutely required in order for asset build + copy to output automatically when you build your project.

Next, you will need to add the correct project type depending on what you are targeting. For instance, the MonoGame DesktopGL Nuget is `MonoGame.Framework.DesktopGL`.  The DirectX version is `MonoGame.Framework.WindowDX`.  Choose the one that is appropriate for your project type

## Step 4: Setup the `dotnet tool`s
Next you will need to setup the **dotnet tool**s used by MonoGame for content/asset building.  Open a new terminal in the project directory and enter the following commands one after the other

```sh
dotnet new tool-manifest
dotnet tool install dotnet-mgcb
dotnet tool install dotnet-mgcb-editor
dotnet tool install dotnet-mgcb-editor-linux
dotnet tool install dotnet-mgcb-editor-windows
dotnet tool install dotnet-mgcb-editor-mac
```

## Step 5: Create Game1.vb Class
Next, create a new class file called `Game1.vb`. Replace all code inside that file with the following. The following is just the default MonoGame template boilerplate converted to VB from C#

```vb
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
```

## Step 6: Edit `Program.vb`
The final step is to edit `Program.vb` so that it creates a new instance of the `Game1` class and runs it.  Replace all code inside `Program.vb` with the following

```vb
Imports System

Module Program
    Sub Main(args As String())
        Using game As New Game1
            game.Run()
        End Using
    End Sub
End Module
```

At this point, you should be able to run the project and get the default CornflowerBlue window as expected.  Happy coding!