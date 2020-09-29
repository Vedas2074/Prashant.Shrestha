class Array {
    void Learn1DArray () {
        byte[] array1 = new byte[10];

        array1[0] = 23;
        array1[10] = 28;

        float[] array2 = new float[] { 2.1f, 34.5f, 67.23f };

        char[] array3 = { 'A', 'B', 'C', 'D' };

        float[] subArray1 = array2[1..3];
    }

    void LearnMulDArray () {
        // 2D array
        int[, ] numbers1 = new int[3, 4];
        numbers1[0, 0] = 345345;
        numbers1[2, 3] = -3453;

        decimal[, ] numbers2 = { { 2.3m, 34.5m }, { 56.4m, 12.45m } };
    }

    void LearnJaggedArray () {
        short[][] numbers = new short[3][];
        numbers[0] = new short[] { 3, 4, 5 };
        numbers[1] = new short[] { 3, 4 };
        numbers[2] = new short[] { 3, 4, 5, 12 };
    }
}