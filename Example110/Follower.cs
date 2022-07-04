using System; // Console
using System.Numerics; // Vector2
using Raylib_cs; // Color

/*
In this class, we have the properties:

- Vector2  Position
- float    Rotation
- Vector2  Scale

- Vector2 TextureSize
- Vector2 Pivot
- Color Color

Methods:

- AddChild(Node child)
- RemoveChild(Node child, bool keepAlive = false)
*/

namespace Movement
{
	class Follower : SpriteNode
	{
		// your private fields here (add Velocity, Acceleration, and MaxSpeed)
        Vector2 velocity = new Vector2 (5, 5);
		Vector2 acceleration = new Vector2 (0,0);

		Vector2 topspeed = new Vector2 (1000,1000);
   

		// constructor + call base constructor
		public Follower() : base("resources/ball.png")
		{
			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 2);
			Color = Color.GREEN;
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			Follow(deltaTime);
			BounceEdges();
		}

		// your own private methods
		private void Follow(float deltaTime)
		{
			Vector2 mouse = Raylib.GetMousePosition();
			
			// Console.WriteLine(mouse);
			
			
			

			// TODO implement
			 Position += velocity * deltaTime;
			 velocity += acceleration * deltaTime;
			 acceleration = mouse;
		}

		private void BounceEdges()
		{
			float scr_width = Settings.ScreenSize.X;
			float scr_height = Settings.ScreenSize.Y;
			float spr_width = TextureSize.X;
			float spr_heigth = TextureSize.Y;

			// TODO implement...
			if (Position.X > scr_width)
            {
				velocity.X = velocity.X * -1;
            }
			if (Position.X < 0)
            {
				velocity.X = 200;
            }


            if (Position.Y > scr_height)
			{
				velocity.Y = velocity.Y * -1;
			}
			if (Position.Y < 0)
            {
				velocity.Y = 100;
            }
		}

	}
}
