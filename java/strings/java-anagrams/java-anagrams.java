static boolean isAnagram(String first, String second) {
    char a[] = first.toLowerCase().toCharArray();
    char b[] = second.toLowerCase().toCharArray();
    Arrays.sort(a);
    Arrays.sort(b);
    return Arrays.equals(a, b);
}