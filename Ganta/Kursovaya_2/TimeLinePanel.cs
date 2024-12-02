using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_2
{
    public class TimelinePanel : Panel
    {
        public List<TimelineEvent> events { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TimelinePanel(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.events = new List<TimelineEvent>();
            this.Paint += new PaintEventHandler(DrawTimeline);
        }

        public void AddEvent(TimelineEvent timelineEvent)
        {
            events.Add(timelineEvent);
            this.Invalidate(); // Перерисовка панели
        }

        private void DrawTimeline(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White); // Очистка фона

            // Расчет координат для временной шкалы
            float panelWidth = this.Width;
            float panelHeight = this.Height;
            float timelineWidth = panelWidth - 40; // Отступы по бокам
            float startX = 20; // Начальная точка по X
            float endX = startX + timelineWidth; // Конечная точка по X
            float timelineY = panelHeight / 2; // Позиция по Y

            // Рисование линии временной шкалы
            g.DrawLine(Pens.Black, startX, timelineY, endX, timelineY);

            // Рисование событий
            TimeSpan totalDuration = EndDate - StartDate;
            foreach (var timelineEvent in events)
            {
                TimeSpan offset = timelineEvent.EventTime - StartDate;
                float position = startX + (offset.Ticks / (float)totalDuration.Ticks) * timelineWidth;

                // Рисование метки события
                g.FillEllipse(Brushes.Blue, position - 5, timelineY - 5, 10, 10);

                // Рисование текста события
                g.DrawString(timelineEvent.Name, this.Font, Brushes.Black, position + 5, timelineY - 20);
            }
        }
        public class TimelineEvent
        {
            public string Name { get; set; }
            public DateTime EventTime { get; set; }

            public TimelineEvent(string name, DateTime eventTime)
            {
                Name = name;
                EventTime = eventTime;
            }
        }
    }
}
