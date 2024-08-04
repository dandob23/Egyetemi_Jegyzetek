#!/usr/bin/env python3
import sys


def welcome(name):
    if name == "Ádám":
        print("Helyes")
    else:
        print("Helytelen")


def main():
    name = sys.argv[1]
    welcome(name)


if __name__ == "__main__":
    main()

