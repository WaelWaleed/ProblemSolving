#include "linked.h"

int main() {
	int yos = 0, rash = 0, element = 0, test = 0, max1 = 0, max2 = 0, min1 = 10000, min2 = 10000, larg = 0, low = 100000;
	linkedList obj1, obj2;
	cin >> test;
	for (int i = 0; i < test; i++) {
		cin >> element;
		obj1.addToLast(element);
		max1 = max(max1, element);
		min1 = min(min1, element);
	}
	for (int i = 0; i < test; i++) {
		cin >> element;
		obj2.addToLast(element);
		max2 = max(max2, element);
		min2 = min(min2, element);
	}
	/*floor*/
	for (int i = 0; i < 2 * test; i++) {
		if (i % 2 != 0) {/*yoss*/
			if (max1 > larg) {
				obj1.print();
				larg = max1;
				obj1.deleete(larg);
				max1 = obj1.maxx();
				obj1.print();
				cout <<"max: " <<max1 << endl;
			}
			else if (min1 < low) {
				obj1.print();
				low = min1;
				obj1.deleete(low);
				min1 = obj1.minn();
				obj1.print();
				cout <<"min: "<< min1 << endl;
			}
		}
		else if (i % 2 == 0) {/*rashed*/
			if (i % 2 != 0) {/*yoss*/
				if (max2 > larg) {
					obj2.print();
					larg = max2;
					obj2.deleete(larg);
					max2 = obj2.maxx();
					obj2.print();
					cout <<"max: " <<max2 << endl;
				}
				else if (min2 < low) {
					obj2.print();
					low = min2;
					obj2.deleete(low);
					min2 = obj2.minn();
					obj2.print();
					cout <<"min: "<< min2 << endl;
				}
			}
		}
	}
	return 0;
}