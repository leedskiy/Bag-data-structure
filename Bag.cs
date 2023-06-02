using System;

namespace bagtask
{
    public class BagElem
    {
        public int elem;
        public int freq;

        public BagElem(int e)
        {
            elem = e;
            freq = 1;
        }
    }

    public class Bag
    {
        public class cantFindElem : Exception { };

        private List<BagElem> bag;
        private int size;
        private int occ1Els;

        public Bag()
        {
            bag = new List<BagElem>();
            size = bag.Count;
            occ1Els = 0;
        }

        public int getSize(){
            return size;
        }

        public void insertElem(int elem)
        {
            bool isInBag = false;

            for (int i = 0; i < size && !isInBag; i++)
            {
                if (elem == bag[i].elem)
                {
                    isInBag = true;
                    
                    if(bag[i].freq == 1){
                        --occ1Els;
                    }
                    
                    ++bag[i].freq;
                }
            }

            if (!isInBag)
            {
                bag.Add(new BagElem(elem));
                ++size;
                ++occ1Els;
            }
        }

        public void removeElem(int elem)
        {
            bool isInBag = false;

            for (int i = 0; i < size && !isInBag; i++)
            {
                if (elem == bag[i].elem)
                {
                    isInBag = true;
                    
                    if (bag[i].freq == 1)
                    {
                        bag.Remove(bag[i]);
                        --size;
                        --occ1Els;
                    }
                    else
                    {
                        --bag[i].freq;

                        if(bag[i].freq == 1){
                            ++occ1Els;
                        }
                    }
                }
            }

            if (!isInBag)
            {
                throw new cantFindElem();
            }
        }

        public int getFreq(int elem)
        {
            bool isInBag = false;

            for (int i = 0; i < size && !isInBag; i++)
            {
                if (elem == bag[i].elem)
                {
                    isInBag = true;
                    return bag[i].freq;
                }
            }

            return 0;
        }

        public int getOcc1Els()
        {
            return occ1Els;
        }

        public override string ToString()
        {
            string temp = "";

            foreach (BagElem e in bag)
            {
                temp = temp + "(" + e.elem + ", " + e.freq + ")" + " ";
            }

            return temp;
        }
    }
}