using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas._100Doors
{
    public class HundreadDoors
    {
        List<Door> _doors = new List<Door>(100);

        public HundreadDoors()
        {
            for (int i = 0; i < 100; i++)
            {
                _doors.Add(new Door());
            }
        }


        public string Run()
        {
            PassDoorsHundreadTimes();
            return WhichDoorsAreOpen();
        }

        public void PassDoorsHundreadTimes()
        {
            for (int passIndex = 0; passIndex < 100; passIndex++)
            {
                for (int doorIndex = 0; doorIndex < _doors.Count; doorIndex++)
                {
                    if ((doorIndex + 1) % (passIndex + 1) == 0)
                    {
                        var door = _doors[doorIndex];
                        ToggleDoor(door);
                    }

                }
            }

        }

        public string WhichDoorsAreOpen()
        {
            var result = "";
            for (int doorIndex = 0; doorIndex < _doors.Count; doorIndex++)
            {
                var door = _doors[doorIndex];
                if (door.Open)
                {
                    result += string.Format("{0}, ", doorIndex + 1);
                }
            }
            char[] charsToTrim = { ',',' ' };
            return result.Trim(charsToTrim);
        }

        private static void ToggleDoor(Door door)
        {
            door.Open = !door.Open;
        }
    }

    internal class Door
    {
        public Door()
        {
            Open = false;
        }
        public bool Open { get; set; }
    }
}
