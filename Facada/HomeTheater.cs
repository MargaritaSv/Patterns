using System;

namespace Facada
{
    public class HomeTheater
    {
        private readonly Database database = new Database();
        private readonly PLay player = new PLay();
        private readonly InterControler roomControler = new InterControler();

        private HomeTheater()
        {
            this.SeedDatabase();
        }


        public static HomeTheater CreateInstance()
        {
            return new HomeTheater();
        }

        public void DisplayAvailableMedia()
        {
            var allMedia = this.database.GetAvailableMedia();

            foreach (var entity in allMedia)
            {
                Console.WriteLine($"{entity.Title} . {entity.FileExtention} -  media");
            }
        }

        public void InitHomeSystem()
        {
            Console.WriteLine("{0}{1}{0}", Environment.NewLine, string.Empty.PadLeft(30, '='));
            this.roomControler.DimLights(50);
            this.roomControler.MoveCurtains(0);
            this.roomControler.HideTable();
            Console.WriteLine("{0}{1}{0}", Environment.NewLine, string.Empty.PadLeft(30, '='));
            this.LoadMedia();
            Console.WriteLine("{0}{1}{0}", Environment.NewLine, string.Empty.PadLeft(30, '='));
            this.player.Play();
        }

        public void Next()
        {
            this.player.Next();
            this.player.Play();
        }

        public void Previous()
        {
            this.player.Previous();
            this.player.Play();
        }

        public void Stop()
        {
            this.player.Stop();
        }

        private void LoadMedia()
        {
            var allMedia = this.database.GetAvailableMedia();

            foreach (var entity in allMedia)
            {
                this.player.Load(entity);
            }
        }

        private void SeedDatabase()
        {
            this.database.Add(new MediaEntity
            {
                Title = "Lord of the ring = Retutn to the king",
                FileExtention = "avi",
                Duration = 160,
                Content = new byte[200]
            });

            this.database.Add(new MediaEntity
            {
                Title = "Lord of the ring = follow",
                FileExtention = "avi",
                Duration = 160,
                Content = new byte[200]
            });

            this.database.Add(new MediaEntity
            {
                Title = "Daryl Hall and John Oates-Maneater",
                FileExtention = "mp3",
                Duration = 160,
                Content = new byte[200]
            });

            this.database.Add(new MediaEntity
            {
                Title = " Madi Diaz -The Other Side",
                FileExtention = "mp4",
                Duration = 160,
                Content = new byte[200]
            });
        }
    }
}
