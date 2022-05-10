using System;
namespace AlgoPractice
{
    public class BstConstruction
    {
        public int value;
        public BstConstruction left;
        public BstConstruction right;

        public BstConstruction(int value)
        {
            this.value = value; 
        }

        public BstConstruction Insert(int value)
        {
            var currentNode = this;

            while (true)
            {
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new BstConstruction(value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else
                {
                    if(currentNode.right == null)
                    {
                        currentNode.right = new BstConstruction(value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }
            return this;
        }

        public bool Contains(int value)
        {
            var currentNode = this;
            while (currentNode != null)
            {
                if(value < currentNode.value)                   
                {
                    currentNode = currentNode.left;
                }
                else if(value > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    return true;
                }
            }
            return false;            
        }


        //itterative 
        public int FindClosestValue(int value)
        {
            var currentNode = this;

            int difference;
            int closestValueToTarget = currentNode.value;

            while (currentNode != null)
            {
                if (value >= currentNode.value)
                {
                    difference = AbsDif(value, currentNode.value);
                    if (difference < AbsDif(closestValueToTarget, value))
                    {
                        closestValueToTarget = currentNode.value;
                    }
                    currentNode = currentNode.right;
                }
                else if (value < currentNode.value)
                {
                    difference = AbsDif(value, currentNode.value);
                    if (difference <= AbsDif(closestValueToTarget, value))
                    {
                        closestValueToTarget = currentNode.value;
                    }
                    currentNode = currentNode.left;
                }

            }
            return closestValueToTarget;
        }

        public static int AbsDif(int target, int node)
        {
            var value = Math.Abs(target - node);
            return value;
        }

        //Recursive
        public int FindClosestValueInBst(BstConstruction tree, int target)
        {
            return findClosestValueInBstHelper(tree, target, 1000000);
        }

        public int findClosestValueInBstHelper(BstConstruction tree, int target, int closest)
        {

            if (Math.Abs(target - tree.value) < Math.Abs(target - closest))
            {
                closest = tree.value;
            }
            if (target > tree.value && tree.right != null)
            {
                Console.Write(tree.right.value);
                return findClosestValueInBstHelper(tree.right, target, closest);
            }
            else if (target < tree.value && tree.left != null)
            {
                Console.Write(tree.left.value);
                return findClosestValueInBstHelper(tree.left, target, closest);
            }
            else
            {
                return closest;
            }
        }

    }

    


}


