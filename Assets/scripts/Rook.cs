using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];
        Chessman c;
        int i, j;

        //right
        i = CurrentX;
        j = CurrentY;
        while (true)
        {
            i++;
            if (i >= 8)
            {
                break;
            }
            c = BoardManager.Instance.Chessmans[i, j];
            if (c == null)
            {
                r[i, j] = true;
            }
            else
            {
                if (c.isWhite != isWhite)
                {
                    r[i, j] = true;
                    break;
                }
            }
        }
        //left
        i = CurrentX;
        j = CurrentY;
        while (true)
        {
            i--;
            if (i < 0)
            {
                break;
            }

            c = BoardManager.Instance.Chessmans[i, j];
            if (c == null)
            {
                r[i, j] = true;
            }
            else
            {
                if (c.isWhite != isWhite)
                {
                    r[i, j] = true;
                    break;
                }
            }
        }

        //up
        i = CurrentX;
        j = CurrentY;
        while (true)
        {
            i++;
            if (i >= 8)
            {
                break;
            }

            c = BoardManager.Instance.Chessmans[i, j];
            if (c == null)
            {
                r[i, j] = true;
            }
            else
            {
                if (c.isWhite != isWhite)
                {
                    r[i, j] = true;
                    break;
                }
            }
        }

        //down
        i = CurrentX;
        j = CurrentY;
        while (true)
        {
            i--;
            if (i < 0)
            {
                break;
            }

            c = BoardManager.Instance.Chessmans[i, j];
            if (c == null)
            {
                r[i, j] = true;
            }
            else
            {
                if (c.isWhite != isWhite)
                {
                    r[i, j] = true;
                    break;
                }
            }
        }

        return r;
    }
}
