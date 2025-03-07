using System;

namespace _2.vector_exercise{
    class Vector{
        private const int max = 10000;
        private int length;
        private int[] array;

        public Vector(){
            array = new int[max];
        }
        public void setLength(int length_) {
            if(length_ > 0 && length_ <= max) {length = length_;}
            else {Console.WriteLine("Length " + length_ + " is not valid.");}
        }
        public int getLength() {
            if(length == 0){Console.WriteLine("Length has not been defined yet. Length = ");}
            return length;
        }
        public void addElement(int pos, int num) { //se sobreescribe la misma posición
            if(getLength() != 0){
                if(pos >= 0 && pos < length){array[pos] = num;}
                else {Console.WriteLine("Position is not valid, value was not add.");}
            }
        }
        public int getElement(int pos){ //si no se agregan elementos, se imprimen como 0.
            if(pos >= 0 && pos < length) {return array[pos];}
            else if (length == 0) {return getLength();}
            else {
                Console.Write("Position is not valid, position must be less than length = ");
                return length;
            }
        }
        public void printVector(){for(int i = 0; i < length; ++i){Console.Write(getElement(i) + ", ");} Console.WriteLine();}
        
        public void insertElement(int pos, int num){
            if(pos == length){
                array[pos] = num;
                setLength(length + 1);
                return;
            } else {
                array[length] = array[length - 1];
                length--;
                insertElement(pos, num);
                length++;
            }
        }
        public void deleteElement(int pos){
            if(pos == length - 1){
                setLength(length - 1);
            } else {
                array[pos] = array[pos+1];
                deleteElement(pos+1);
            }
        }
        public bool compareVectors(Vector v){ //el orden no importa
            selectionSort();
            v.selectionSort();
            if(getLength() == v.getLength()){
                for(int i = 0; i < getLength(); ++i){
                    if(v.getElement(i) != array[i]) {return false;}
                } return true;
            } return false;
        }
        public void union(Vector v){ //se escribe la union en v1 y se mantiene v2.
            if(compareVectors(v)){return;}
            for(int i = 0; i < v.getLength(); ++i){
                setLength(getLength() + 1);
                array[length] = v.getElement(i);
            }
            deleteDuplicates();
        }
        public bool subconjunto(Vector v){
            deleteDuplicates();
            if(v.getLength() <= length){
                int i = 0;
                int j = 0;
                while(i < length && j < v.getLength()){
                    if(v.getElement(i) != array[j]){
                        i++;
                        if(i == length -1) {return false;}
                    } else {
                        i++;
                        j++;
                    }
                }
                return true;
            }
            return false;
        }
        
        public void deleteDuplicates(){
            selectionSort();
            int i = 0;
            while(i < length - 1){
                if(array[i] == array[i+1]) {deleteElement(i+1);}
                else {++i;}
            }
        }

        public void selectionSort(){
            for(int i = 0; i < getLength(); ++i){
                int min = i;
                for(int j = i+1; j < getLength(); ++j){
                    if(array[j] < array[min]){
                        min = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
        public void insertionSort() {
            for(int i = 1; i < getLength(); ++i){
                int key = array[i];
                int j = i - 1;
                while(j >= 0 && array[j] > key){
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}