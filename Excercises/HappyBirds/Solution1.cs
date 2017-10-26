using System;

namespace Excercises.HappyBirds
{
    public static class Solution1
    {
        private class BirdsFlyingAround
        {
            public void ArrangeBirdInPattern(IBird bird)
            {
                Penguin penguin = bird as Penguin;
                if (penguin != null)
                {
                    ArrangeBirdOnGround(penguin);
                }
                else
                {
                    ArrangeBirdInSky(bird);
                }
            }

            private void ArrangeBirdInSky(IBird bird)
            {
                bird.SetAltitude(20.0);
                bird.SetLocation(59.0, 10.30);
            }

            private void ArrangeBirdOnGround(Penguin penguin)
            {
                penguin.SetLocation(59.1, 10.32);
            }
        }

        interface IBird
        {
            void SetLocation(double latitude, double longitude);
            void SetAltitude(double altitude);
            void Draw();
        }

        class Penguin : IBird
        {
            public void SetLocation(double latitude, double longitude)
            {
                // update location
            }

            public void SetAltitude(double altitude)
            {
                throw new Exception("Altitude can't be set because penguins can't fly.");
            }

            public void Draw()
            {
                // draw a penguin
            }
        }
    }
}