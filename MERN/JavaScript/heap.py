class Heap:
    def __init__(self):
        self._heap = [None]
    
    def add(self, val):
        pos = len(self._heap)
        self._heap.append(val)
        while pos != 1 and (self._heap[pos] < self._heap[pos // 2]):
            tmp = self._heap[pos]
            self._heap[pos] = self._heap[pos//2]
            self._heap[pos//2] = tmp
            pos = pos // 2
        return self

    def remove(self):
        val = self._heap[1]
        self._heap[1] = self._heap[-1]
        self._heap.pop()
        n, c1, c2 = 1, 2, 3
        l = len(self._heap)
        while (c1 < 1 and self._heap[n] > self._heap[c1]) or (c2 < l and self._heap[n] > self._heap[c2]):
            if self._heap[c1] < self._heap[c2]:
                tmp = self._heap[n]
                self._heap[n] = self._heap[c1]
                self._heap[c1] = tmp
                n = c1
                c1 = 2*n
                c2 = 2*n + 1
            else:
                tmp = self._heap[n]
                self._heap[n] = self._heap[c2]
                self._heap[c2] = tmp
                n = c2
                c1 = 2*n
                c2 = 2*n + 1
        return val

# def heapfunc(arr):
#     for i in range(len(arr)):
#         j = i + 1
#         while (j>1):
#             if arr[j-1] < arr[(j//2)-1]:
#                 tmp = arr[j-1]
#                 arr[j-1] = arr[(j//2)-1]
#                 arr[(j//2)-1] = tmp
#             else:
#                 break
#             j = j//2
#     return arr


# arr = [16, 14, 10, 8, 7 ,9, 3, 2, 4, 1]
# print(heapfunc(arr))

h1 = Heap()
# h1.add(5).add(2).add(7).add(10).add(9).add(1)
h1.add(5)
h1.add(2)
h1.add(7)
h1.add(10)
h1.add(9)
h1.add(1)
print(h1._heap)
h1.remove()
print(h1._heap)