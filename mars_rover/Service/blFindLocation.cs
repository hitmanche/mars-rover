using System;
using System.Collections.Generic;
using System.Text;

namespace mars_rover.Service
{
    public class blFindLocation
    {
        int prmX, prmY;
        string prmAspect, prmReceiceDestiny;
        public blFindLocation(int _prmX, int _prmY, string _prmAspect, string _prmReceiveDestiny)
        {
            prmX = _prmX;
            prmY = _prmY;
            prmAspect = _prmAspect;
            prmReceiceDestiny = _prmReceiveDestiny;
        }

        public string GiveDestiny()
        {
            for (int i = 0; i < prmReceiceDestiny.Length; i++)
            {
                switch (prmReceiceDestiny[i])
                {
                    case 'L':
                        RotatePositionLeft();
                        break;
                    case 'R':
                        RotatePositionRight();
                        break;
                    case 'M':
                        MovePosition();
                        break;
                    default:
                        break;
                }
            }

            return "[" + prmX + "," + prmY + "," + prmAspect + "]";
        }

        private void MovePosition()
        {
            switch (prmAspect)
            {
                case "N":
                    prmY += 1;
                    break;
                case "S":
                    prmY -= 1;
                    break;
                case "W":
                    prmX -= 1;
                    break;
                case "E":
                    prmX += 1;
                    break;
                default:
                    break;
            }
        }

        private void RotatePositionLeft()
        {
            switch (prmAspect)
            {
                case "N":
                    prmAspect = "W";
                    break;
                case "S":
                    prmAspect = "E";
                    break;
                case "W":
                    prmAspect = "S";
                    break;
                case "E":
                    prmAspect = "N";
                    break;
                default:
                    break;
            }
        }
        private void RotatePositionRight()
        {
            switch (prmAspect)
            {
                case "N":
                    prmAspect = "E";
                    break;
                case "S":
                    prmAspect = "W";
                    break;
                case "W":
                    prmAspect = "N";
                    break;
                case "E":
                    prmAspect = "S";
                    break;
                default:
                    break;
            }
        }

    }
}
