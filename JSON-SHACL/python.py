import sys
import json
from jsonschema import Draft7Validator

class vai:
	def funcao(self,x):
		jsonSchema_data = json.load(x)

		try:
		    res = Draft7Validator.check_schema(jsonSchema_data)
		    print("success, error: {}".format(res))
		except:
		    print("err: {}".format(sys.exc_info()))