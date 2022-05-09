import math


class PrimeGenerator(object):

    def generate_primes(self, max_num):
        # Implemente aqui sua solução
        if max_num is None:
            raise TypeError('max_num cant be None') 
        array = [True] * max_num
        array[0] = False
        array[1] = True
        prime = 2
        while prime <= math.sqrt(max_num):
            self._cross_off(array, prime)
            prime = self._next_prime(array, prime)
        return array
            
    def _cross_off(self, array, prime):
       # Implemente aqui sua solução
        for i in range(prime*prime, len(array), prime):
            array[i] = False

    def _next_prime(self, array, prime):
        # Implemente aqui sua solução
        next = prime + 1
        while next < len(array) and not array[next]:
            next += 1
        return next