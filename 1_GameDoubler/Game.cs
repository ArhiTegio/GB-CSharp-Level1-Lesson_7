using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_GameDoubler
{
    class Game
    {
        private int position = 1;
        private int goal = 0;
        private List<Action> ListStep = new List<Action>();

        public int Goal { get => goal; }
        public int Position { get => position; }
        public int Step { get => ListStep.Count; }

        public Game()
        {
            goal = (new Random()).Next(10, 100);
            position = 1;
            ListStep = new List<Action>();
        }

        public int Multiplier()
        {
            ListStep.Add(Action.Multiplier);
            return position = position * 2;
        }

        public int Addition()
        {
            ListStep.Add(Action.Addition);
            return position = position + 1;
        }

        private int AntiMultiplier()
        {
            ListStep.RemoveAt(ListStep.Count - 1);
            return position = position / 2;
        }

        private int AntiAddition()
        {
            ListStep.RemoveAt(ListStep.Count - 1);
            return position = position - 1;
        }

        public bool StepBack()
        {
            if (ListStep.Count == 0)
                return false;
            else
            {
                if (ListStep[ListStep.Count - 1] == Action.Addition)
                    AntiAddition();
                else
                    AntiMultiplier();
            }
            return true;
        }        
    }

    enum Action
    {
        Multiplier,
        Addition
    }


}
