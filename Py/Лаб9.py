import re


def numReplacer(message, character):
    replaced = re.sub('\d', character, message)
    return replaced


yourMessage = input("Enter your message: ")
yourCharacter = input("Enter the raplacing character: ")
print(numReplacer(yourMessage, yourCharacter))
