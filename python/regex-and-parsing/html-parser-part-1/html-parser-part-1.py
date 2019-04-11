# Enter your code here. Read input from STDIN. Print output to STDOUT

from html.parser import HTMLParser
n = int(input())

page = []
for line in range(n):
  page.append(str(input()))

class MyHTMLParser(HTMLParser):
    def handle_starttag(self,tag,args):
        self.handler("Start",tag,args)
    def handle_endtag(self,tag):
        self.handler("End",tag)
    def handle_startendtag(self,tag,args):
        self.handler("Empty",tag,args)
    def handler(self,type,tag,args=[]):
        print("%-6s: %s" % (type,tag))
        if len(args) > 0:
            for a in args:
                print("-> %s > %s" % (a[0],a[1]))

parser=MyHTMLParser()
parser.feed("\n".join(page))
