
def is_one_letter_diff(word1, word2):
    s = sum([word1[i] != word2[i] for i in range(len(word1))])
    return s == 1

def get_distance(start, end, words):
    level = 1
    previousWords = [start]
    while len(previousWords) > 0:
        nextWords = []
        for previousWord in previousWords:
            if is_one_letter_diff(end, previousWord):
                return level + 1
            for word in words:
                if not is_one_letter_diff(previousWord, word):
                    continue
                nextWords.append(word)
                words.remove(word)
        previousWords = nextWords
        level += 1

words = [line.rstrip('\n') for line in open('data.txt')]
d = get_distance("sand", "hold", words)
