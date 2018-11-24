require 'rspec'
require 'roman_number_assembler'

describe 'Convert primitives' do

    context 'when converting 1 to roman number' do
        it 'should convert be I' do
            sut    = RomanNumberAssembler.new
            actual = sut.convert(1)
            expect(actual).to eq ('I')
        end
    end

    context 'given 5' do
        context 'when converting to roman number' do
            before do
                @number = 5
                @sut    = RomanNumberAssembler.new
            end

            it 'should be V' do
                actual = @sut.convert(@number)
                expect(actual).to eq('V')
            end
        end
    end


    # context 'successfull response' do
    #   let(:resource) do
    #     Factory(:resource)
    #   end
    #
    #   before do
    #     get :show, id: resource.id
    #   end
    #
    #   specify do
    #     response.should be_successfull
    #   end
    # end
end
