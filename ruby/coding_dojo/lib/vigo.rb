# $today = 'Pazartesi'
# def greet_user(user_name)
#     out_text = "Merhaba #{user_name}, bugün #{$today}"
#     puts out_text
# end
#
# puts "Bugün günlerden ne? #{$today}"
# greet_user('vigo')  # Merhaba vigo, bugün Pazartesi


# MY_AGE = 18
# your_age = 22
#
# puts defined?(MY_AGE)    # constant
# puts defined?(your_age)  # local-variable
# puts "#{MY_AGE}"

#
# class User
#     attr_accessor :name
#     @@instance_count=0
#
#     def initialize(name)
#         @name           = name
#         @@instance_count+=1
#     end
#
#     def greet
#         "Hello #{@name}"
#     end
#
#     def self.instance_count
#         @@instance_count
#     end
# end
#
# u = User.new('Ugur')
# puts u.greet
# puts u.name
#
# u2 = User.new 'erdem'
# puts User.instance_count
#
# u3 = User.new 'erdem'
# puts User.instance_count


# puts global_variables

# a = [] # Bu bir dizi / Array
# a.[]= 5, "Merhaba" # 0 indekli, 5.eleman Merhaba olsun
# p a

# class User
#
#     def email=(email)
#         @email = email
#     end
# end
#
# u = User.new
# u # => #<User:0x007ff7229ed880>
#
# u.email = 'vigo@xyz.com'
# u
#

#
# def merhaba(*isimler)
#     puts "Merhaba #{isimler.join(' ve ')}"
# end
#
# merhaba('vigo') # => "Merhaba vigo"
# merhaba('vigo', 'yeşim', 'ezel') # => "Merhaba vigo ve yeşim ve ezel"
#
# merhaba 'dünya', 'uzay', 'evren', 'ay'
#
# def custom_numbers(first, second, *others)
#     puts "ilk sayı: #{first}"
#     puts "ikinci sayı : #{second}"
#     puts "diğer sayılar : #{others.join(',')}"
# end
#
# custom_numbers 1, 2, 50, 100 # => nil


# def numerator
#     yield 10
#     yield 4
#     yield 8
# end
#
# numerator do |number|
#     puts "Geçilen sayı #{number}"
# end


# items = ["Bu bir", "bu iki", "bu üç"]
# print_each_element = lambda { |item| puts item }
# items.each(&print_each_element)
#
# items = ["Bu bir", "bu iki", "bu üç"]
# def print_each_element(item)
#     puts item
# end
# items.each(&method(:print_each_element))

# 'merhaba'.each_char {|c| puts c }
#
# a = [1, 2, 3]
# a.combination(1).to_a # => [[1], [2], [3]]
# a.combination(2).to_a # => [[1, 2], [1, 3], [2, 3]]
#
# a.combination(2) { |c| puts "Olasıklar: #{c.join(" ve ")}" }


# p [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5].chunk { |n| n.even? }.to_a #.each { |m| puts m }

# h = { "a" => 100, "b" => 200, "c" => 0 }
#
# # 2'li dilimlere ayırdık
# h.each_slice(2){ |s| puts "slice: #{s}" }
