class UniqueChars(object):

    def has_unique_chars(self, string):
        if string == None:
            raise TypeError('can not be none!')
        hashmap = set({})
        for i in string:
            if i not in hashmap:
                hashmap.add(i)
            else:
                return False
        return True