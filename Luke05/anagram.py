import urllib2
from collections import Counter


def is_anagram(word, anagrams):
    for anagram in anagrams:
        if anagram != word and Counter(word) == Counter(anagram):
            print anagram
            return True
    return False


data = urllib2.urlopen("http://pastebin.com/raw.php?i=sGbqMyCa").read()
data = data.split("\n")
counter = 0


for line in data:
    if is_anagram(line, data):
        counter += 1

print counter
