/*  dsp.cs

This file is part of a program that implements a Software-Defined Radio.

Copyright (C) 2013-2015 Warren Pratt, NR0V

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

The author can be reached by email at  

warren@wpratt.com

*/

namespace PowerSDR
{
    using System;
    using System.Runtime.InteropServices;

    unsafe class wdsp
	{

        #region wdsp method definitions

        [DllImport("wdsp.dll", EntryPoint = "OpenChannel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void OpenChannel(int channel, int in_size, int dsp_size, int input_samplerate, int dsp_rate, int output_samplerate, int type, int state, double tdelayup, double tslewup, double tdelaydown, double tslewdown, int bfo);

        [DllImport("wdsp.dll", EntryPoint = "CloseChannel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CloseChannel(int channel);

        [DllImport("wdsp.dll", EntryPoint = "SetInputBuffsize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetInputBuffsize(int channel, int in_size);

        [DllImport("wdsp.dll", EntryPoint = "SetDSPBuffsize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetDSPBuffsize(int channel, int dsp_size);

        [DllImport("wdsp.dll", EntryPoint = "SetInputSamplerate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetInputSamplerate(int channel, int rate);

        [DllImport("wdsp.dll", EntryPoint = "SetDSPSamplerate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetDSPSamplerate(int channel, int rate);

        [DllImport("wdsp.dll", EntryPoint = "SetOutputSamplerate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetOutputSamplerate(int channel, int rate);

        [DllImport("wdsp.dll", EntryPoint = "SetAllRates", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetAllRates(int channel, int in_rate, int dsp_rate, int out_rate);

        [DllImport("wdsp.dll", EntryPoint = "SetChannelState", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetChannelState(int channel, int state, int dmode);

        [DllImport("wdsp.dll", EntryPoint = "SetChannelTDelayUp", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetChannelTDelayUp(int channel, double time);

        [DllImport("wdsp.dll", EntryPoint = "SetChannelTSlewUp", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetChannelTSlewUp(int channel, double time);

        [DllImport("wdsp.dll", EntryPoint = "SetChannelTDelayDown", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetChannelTDelayDown(int channel, double time);

        [DllImport("wdsp.dll", EntryPoint = "SetChannelTSlewDown", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetChannelTSlewDown(int channel, double time);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAMode(int channel, DSPMode mode);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAMode(int channel, DSPMode mode);

        [DllImport("wdsp.dll", EntryPoint = "fexchange0", CallingConvention = CallingConvention.Cdecl)]
        public static extern void fexchange0 (int channel, double* Cin, double* Cout, int* error);

        [DllImport("wdsp.dll", EntryPoint = "fexchange2", CallingConvention = CallingConvention.Cdecl)]
        public static extern void fexchange2(int channel, float* Iin, float* Qin, float* Iout, float* Qout, int* error);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCMode(int channel, AGCMode mode);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCFixed", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCFixed(int channel, double fixed_agc);

        [DllImport("wdsp.dll", EntryPoint = "GetRXAAGCTop", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetRXAAGCTop(int channel, double* max_agc);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCTop", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCTop(int channel, double max_agc);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCAttack", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCAttack(int channel, int attack);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCDecay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCDecay(int channel, int decay);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCHang", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCHang(int channel, int hang);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCSlope", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCSlope(int channel, int slope);

        [DllImport("wdsp.dll", EntryPoint = "GetRXAAGCHangThreshold", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetRXAAGCHangThreshold(int channel, int* hangthreshold);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCHangThreshold", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCHangThreshold(int channel, int hangthreshold);

        [DllImport("wdsp.dll", EntryPoint = "GetRXAAGCThresh", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetRXAAGCThresh(int channel, double* thresh, double size, double rate);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCThresh", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCThresh(int channel, double thresh, double size, double rate);

        [DllImport("wdsp.dll", EntryPoint = "GetRXAAGCHangLevel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetRXAAGCHangLevel(int channel, double* hanglevel);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAGCHangLevel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAGCHangLevel(int channel, double hanglevel);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAALCDecay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAALCDecay(int channel, int decay);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAMDSBMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAMDSBMode(int channel, int sbmode);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAMDFadeLevel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAMDFadeLevel(int channel, int fadelevel);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAMSQRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAMSQRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAMSQThreshold", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAMSQThreshold(int channel, double threshold);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAAMSQMaxTail", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAAMSQMaxTail(int channel, double tail);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAAMSQRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAAMSQRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAAMSQMutedGain", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAAMSQMutedGain(int channel, double dBlevel);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAAMSQThreshold", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAAMSQThreshold(int channel, double threshold);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAAMCarrierLevel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAAMCarrierLevel(int channel, double carrier);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANFRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAANFRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANFVals", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAANFVals(int channel, int taps, int delay, double gain, double leak);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANFTaps", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRXAANFTaps(int channel, int taps);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANFDelay", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRXAANFDelay(int channel, int delay);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANFGain", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRXAANFGain(int channel, double gain);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANFLeakage", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRXAANFLeakage(int channel, double leakage);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANFPosition", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAANFPosition(int channel, int position);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANRRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAANRRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANRVals", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAANRVals(int channel, int taps, int delay, double gain, double leak);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANRTaps", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRXAANRTaps(int channel, int taps);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANRDelay", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRXAANRDelay(int channel, int delay);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANRGain", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRXAANRGain(int channel, double gain);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANRLeakage", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRXAANRLeakage(int channel, double leakage);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAANRPosition", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAANRPosition(int channel, int position);

        [DllImport("wdsp.dll", EntryPoint = "SetRXABandpassFreqs", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXABandpassFreqs(int channel, double low, double high);

        [DllImport("wdsp.dll", EntryPoint = "SetRXABandpassWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXABandpassWindow(int channel, int wintype);

        [DllImport("wdsp.dll", EntryPoint = "SetTXABandpassFreqs", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXABandpassFreqs(int channel, double low, double high);

        [DllImport("wdsp.dll", EntryPoint = "SetTXABandpassWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXABandpassWindow(int channel, int wintype);

        [DllImport("wdsp.dll", EntryPoint = "SetRXACBLRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXACBLRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXACFIRRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXACFIRRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXACompressorRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXACompressorRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXACompressorGain", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXACompressorGain(int channel, double gain);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAosctrlRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAosctrlRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAEMNRRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAEMNRRun(int channel, int run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAEMNRPosition", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAEMNRPosition(int channel, int position);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAEMNRgainMethod", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAEMNRgainMethod(int channel, int method);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAEMNRnpeMethod", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAEMNRnpeMethod(int channel, int method);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAEMNRaeRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAEMNRaeRun(int channel, int run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAEQRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAEQRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAEQRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAEQRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAGrphEQ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAGrphEQ(int channel, int* ptr);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAGrphEQ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAGrphEQ(int channel, int* ptr);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAGrphEQ10", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAGrphEQ10(int channel, int* ptr);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAGrphEQ10", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAGrphEQ10(int channel, int* ptr);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAFMDeviation", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAFMDeviation(int channel, double deviation);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAFMSQRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAFMSQRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAFMSQThreshold", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAFMSQThreshold(int channel, double threshold);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAFMDeviation", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAFMDeviation(int channel, double deviation);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAFMEmphPosition", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAFMEmphPosition(int channel, bool position);

        [DllImport("wdsp.dll", EntryPoint = "SetTXACTCSSRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXACTCSSRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXACTCSSFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXACTCSSFreq(int channel, double freq_hz);

        [DllImport("wdsp.dll", EntryPoint = "SetRXACTCSSRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXACTCSSRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXACTCSSFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXACTCSSFreq(int channel, double freq_hz);

        [DllImport("wdsp.dll", EntryPoint = "SetTXALevelerTop", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXALevelerTop(int channel, double maxgain);

        [DllImport("wdsp.dll", EntryPoint = "SetTXALevelerDecay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXALevelerDecay(int channel, int decay);

        [DllImport("wdsp.dll", EntryPoint = "SetTXALevelerSt", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXALevelerSt(int channel, bool state);

        [DllImport("wdsp.dll", EntryPoint = "GetRXAMeter", CallingConvention = CallingConvention.Cdecl)]
        public static extern double GetRXAMeter(int channel, rxaMeterType meter);

        [DllImport("wdsp.dll", EntryPoint = "GetTXAMeter", CallingConvention = CallingConvention.Cdecl)]
        public static extern double GetTXAMeter(int channel, txaMeterType meter);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPanelRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPanelRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPanelSelect", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPanelSelect(int channel, int select);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPanelGain1", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPanelGain1(int channel, double gain);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPanelPan", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPanelPan(int channel, double pan);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPanelBinaural", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPanelBinaural(int channel, bool bin);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPanelRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPanelRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPanelGain1", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPanelGain1(int channel, double gain);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAShiftFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAShiftFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetRXASpectrum", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASpectrum(int channel, int flag, int disp, int ss, int LO);

        [DllImport("wdsp.dll", EntryPoint = "TXAGetSpecF1", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TXAGetSpecF1(int channel, float* results);

        [DllImport("wdsp.dll", EntryPoint = "RXAGetaSipF", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXAGetaSipF(int channel, float* results, int size);

        [DllImport("wdsp.dll", EntryPoint = "RXAGetaSipF1", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXAGetaSipF1(int channel, float* results, int size);

        [DllImport("wdsp.dll", EntryPoint = "TXAGetaSipF", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TXAGetaSipF(int channel, float* results, int size);

        [DllImport("wdsp.dll", EntryPoint = "TXAGetaSipF1", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TXAGetaSipF1(int channel, float* results, int size);

        [DllImport("wdsp.dll", EntryPoint = "create_resampleFV", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* create_resampleFV(int in_rate, int out_rate);

        [DllImport("wdsp.dll", EntryPoint = "xresampleFV", CallingConvention = CallingConvention.Cdecl)]
        public static extern void xresampleFV(float* input, float* output, int numsamps, int* outsamps, void* ptr);

        [DllImport("wdsp.dll", EntryPoint = "destroy_resampleFV", CallingConvention = CallingConvention.Cdecl)]
        public static extern void destroy_resampleFV(void* ptr);

        [DllImport("wdsp.dll", EntryPoint = "WDSPwisdom", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WDSPwisdom(string directory);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPreGenRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPreGenRun(int channel, int run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPreGenMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPreGenMode(int channel, int mode);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPreGenToneMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPreGenToneMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPreGenToneFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPreGenToneFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPreGenNoiseMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPreGenNoiseMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPreGenSweepMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPreGenSweepMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPreGenSweepFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPreGenSweepFreq(int channel, double freq1, double freq2);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAPreGenSweepRate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAPreGenSweepRate(int channel, double rate);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenRun(int channel, int run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenMode(int channel, int mode);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenToneMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenToneMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenToneFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenToneFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenNoiseMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenNoiseMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenSweepMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenSweepMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenSweepFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenSweepFreq(int channel, double freq1, double freq2);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenSweepRate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenSweepRate(int channel, double rate);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenSawtoothMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenSawtoothMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenSawtoothFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenSawtoothFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenTriangleMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenTriangleMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenTriangleFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenTriangleFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenPulseMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenPulseMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenPulseFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenPulseFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenPulseDutyCycle", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenPulseDutyCycle(int channel, double dc);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenPulseToneFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenPulseToneFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPreGenPulseTransition", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPreGenPulseTransition(int channel, double transtime);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenRun(int channel, int run);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenMode(int channel, int mode);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenToneFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenToneFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenToneMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenToneMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenTTMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenTTMag(int channel, double mag1, double mag2);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenTTFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenTTFreq(int channel, double freq1, double freq2);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenSweepMag", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenSweepMag(int channel, double mag);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenSweepFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenSweepFreq(int channel, double freq1, double freq2);

        [DllImport("wdsp.dll", EntryPoint = "SetTXAPostGenSweepRate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTXAPostGenSweepRate(int channel, double rate);

        // diversity

        [DllImport("wdsp.dll", EntryPoint = "create_divEXT", CallingConvention = CallingConvention.Cdecl)]
        public static extern void create_divEXT(int id, int run, int nr, int size);

        [DllImport("wdsp.dll", EntryPoint = "destroy_divEXT", CallingConvention = CallingConvention.Cdecl)]
        public static extern void destroy_divEXT (int id);

        [DllImport("wdsp.dll", EntryPoint = "SetEXTDIVRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEXTDIVRun(int id, int run);

        [DllImport("wdsp.dll", EntryPoint = "SetEXTDIVNr", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEXTDIVNr (int id, int nr);

        [DllImport("wdsp.dll", EntryPoint = "SetEXTDIVOutput", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEXTDIVOutput (int id, int output);

        [DllImport("wdsp.dll", EntryPoint = "SetEXTDIVRotate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEXTDIVRotate(int id, int nr, double* Irotate, double* Qrotate);

        // eer

        [DllImport("wdsp.dll", EntryPoint = "create_eerEXT", CallingConvention = CallingConvention.Cdecl)]
        public static extern void create_eerEXT(int id, int run, int size, int rate, double mgain, double pgain, bool rundelays, double mdelay, double pdelay, int amiq);

        [DllImport("wdsp.dll", EntryPoint = "destroy_eerEXT", CallingConvention = CallingConvention.Cdecl)]
        public static extern void destroy_eerEXT(int id);

        [DllImport("wdsp.dll", EntryPoint = "xeerEXTF", CallingConvention = CallingConvention.Cdecl)]
        public static extern void xeerEXTF(int id, float* inI, float* inQ, float* outI, float* outQ, float* outM);

        [DllImport("wdsp.dll", EntryPoint = "SetEERRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERRun(int id, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetEERAMIQ", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERAMIQ(int id, bool amiq);

        [DllImport("wdsp.dll", EntryPoint = "SetEERMgain", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERMgain (int id, double gain);

        [DllImport("wdsp.dll", EntryPoint = "SetEERPgain", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERPgain(int id, double gain);

        [DllImport("wdsp.dll", EntryPoint = "SetEERRunDelays", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERRunDelays(int id, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetEERMdelay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERMdelay(int id, double delay);

        [DllImport("wdsp.dll", EntryPoint = "SetEERPdelay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERPdelay(int id, double delay);

        [DllImport("wdsp.dll", EntryPoint = "SetEERSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERSize(int id, int size);

        [DllImport("wdsp.dll", EntryPoint = "SetEERSamplerate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetEERSamplerate(int id, int rate);

        // apf

        [DllImport("wdsp.dll", EntryPoint = "SetRXASPCWRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASPCWRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXASPCWFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASPCWFreq(int channel, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetRXASPCWBandwidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASPCWBandwidth(int channel, double bw);

        [DllImport("wdsp.dll", EntryPoint = "SetRXASPCWGain", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASPCWGain(int channel, double gain);

        // dolly filter

        [DllImport("wdsp.dll", EntryPoint = "SetRXAmpeakRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAmpeakRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAmpeakFilFreq", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAmpeakFilFreq(int channel, int fil, double freq);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAmpeakFilBw", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAmpeakFilBw(int channel, int fil, double bw);

        [DllImport("wdsp.dll", EntryPoint = "SetRXAmpeakFilGain", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXAmpeakFilGain(int channel, int fil, double gain);

        // snba

        [DllImport("wdsp.dll", EntryPoint = "SetRXASNBARun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASNBARun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "SetRXASNBAk1", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASNBAk1(int channel, double k1);

        [DllImport("wdsp.dll", EntryPoint = "SetRXASNBAk2", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASNBAk2(int channel, double k2);

        // notched bandpass

        [DllImport("wdsp.dll", EntryPoint = "RXANBPAddNotch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int RXANBPAddNotch(int channel, int notch, double fcenter, double fwidth, bool active);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPGetNotch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int RXANBPGetNotch(int channel, int notch, double* fcenter, double* fwidth, int* active);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPDeleteNotch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int RXANBPDeleteNotch(int channel, int notch);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPEditNotch", CallingConvention = CallingConvention.Cdecl)]
        public static extern int RXANBPEditNotch(int channel, int notch, double fcenter, double fwidth, bool active);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPGetNumNotches", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXANBPGetNumNotches(int channel, int* nnotches);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPSetTuneFrequency", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXANBPSetTuneFrequency(int channel, double tunefreq);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPSetShiftFrequency", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXANBPSetShiftFrequency(int channel, double shift);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPSetNotchesRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXANBPSetNotchesRun(int channel, bool run);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPSetFreqs", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXANBPSetFreqs(int channel, double flow, double fhigh);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPSetWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXANBPSetWindow(int channel, int wintype);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPGetMinNotchWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXANBPGetMinNotchWidth(int channel, double* minwidth);

        [DllImport("wdsp.dll", EntryPoint = "RXANBPSetAutoIncrease", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXANBPSetAutoIncrease(int channel, bool autoincr);

        [DllImport("wdsp.dll", EntryPoint = "SetRXASNBAOutputBandwidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetRXASNBAOutputBandwidth(int channel, double flow, double fhigh);

        [DllImport("wdsp.dll", EntryPoint = "RXASetMP", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXASetMP(int channel, bool mp);

        [DllImport("wdsp.dll", EntryPoint = "TXASetMP", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TXASetMP(int channel, bool mp);

        [DllImport("wdsp.dll", EntryPoint = "RXASetNC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RXASetNC(int channel, int nc);

        [DllImport("wdsp.dll", EntryPoint = "TXASetNC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TXASetNC(int channel, int nc);

        #endregion

        #region Enums

        public enum MeterType
        {
            SIGNAL_STRENGTH = 0,
            AVG_SIGNAL_STRENGTH,
            ADC_REAL,
            ADC_IMAG,
            AGC_GAIN,
            MIC,
            PWR,
            ALC,
            EQ,
            LEVELER,
            COMP,
            CPDR,
            ALC_G,
            LVL_G,
            MIC_PK,
            ALC_PK,
            EQ_PK,
            LEVELER_PK,
            COMP_PK,
            CPDR_PK,
        }

        public enum rxaMeterType
        {
            RXA_S_PK,
            RXA_S_AV,
            RXA_ADC_PK,
            RXA_ADC_AV,
            RXA_AGC_GAIN,
            RXA_AGC_PK,
            RXA_AGC_AV,
            RXA_METERTYPE_LAST
        };

        public enum txaMeterType
        {
            TXA_MIC_PK,
            TXA_MIC_AV,
            TXA_EQ_PK,
            TXA_EQ_AV,
            TXA_LVLR_PK,
            TXA_LVLR_AV,
            TXA_LVLR_GAIN,
            TXA_COMP_PK,
            TXA_COMP_AV,
            TXA_ALC_PK,
            TXA_ALC_AV,
            TXA_ALC_GAIN,
            TXA_OUT_PK,
            TXA_OUT_AV,
            TXA_METERTYPE_LAST
        };

        #endregion


        #region wdsp map methods

        const int txachannel = 4;
        public static int id(uint thread, uint subrx)
        {	// (thread, subrx) => channel mapping
            switch (2 * thread + subrx)
            {
                case 0:
                    return  0;	        // rx0, subrx0
                case 1:
                    return  1;	        // rx0, subrx1
                case 2:
                    return txachannel;	// tx
                case 3:
                    return txachannel;	// tx
                case 4:
                    return  2;	        // rx1, subrx0
                case 5:
                    return  3;	        // rx1, subrx1
                default:
                    return -1;	        // error
            }
        }

        public static float CalculateRXMeter (uint thread, uint subrx, MeterType MT)
        {
	        int channel = id(thread, subrx);
	        double val;
	        switch (MT)
	        {
	        case MeterType.SIGNAL_STRENGTH:
		        val = GetRXAMeter (channel, rxaMeterType.RXA_S_PK);
		        break;
	        case MeterType.AVG_SIGNAL_STRENGTH:
                val = GetRXAMeter(channel, rxaMeterType.RXA_S_AV);
		        break;
	        case MeterType.ADC_REAL:
                val = GetRXAMeter(channel, rxaMeterType.RXA_ADC_PK);
		        break;
	        case MeterType.ADC_IMAG:
                val = GetRXAMeter(channel, rxaMeterType.RXA_ADC_PK);
		        break;
	        case MeterType.AGC_GAIN:
                val = GetRXAMeter(channel, rxaMeterType.RXA_AGC_GAIN);
		        break;
	        default:
		        val = -400.0;
		        break;
	        }
	        return (float)val;
        }

        public static float CalculateTXMeter (uint thread, MeterType MT)
        {
	        int channel = txachannel;
	        double val;
	        switch (MT)
	        {
	        case MeterType.MIC:
                    val = GetTXAMeter(channel, txaMeterType.TXA_MIC_AV);
		        break;
	        case MeterType.PWR:
                val = GetTXAMeter(channel, txaMeterType.TXA_OUT_PK);
		        break;
	        case MeterType.ALC:
                val = GetTXAMeter(channel, txaMeterType.TXA_ALC_AV);
		        break;
	        case MeterType.EQ:
                val = GetTXAMeter(channel, txaMeterType.TXA_EQ_AV);
		        break;
	        case MeterType.LEVELER:
                val = GetTXAMeter(channel, txaMeterType.TXA_LVLR_AV);
		        break;
	        case MeterType.COMP:
                val = GetTXAMeter(channel, txaMeterType.TXA_COMP_AV);
		        break;
	        case MeterType.CPDR:
                val = GetTXAMeter(channel, txaMeterType.TXA_COMP_AV);
		        break;
	        case MeterType.ALC_G:
                val = GetTXAMeter(channel, txaMeterType.TXA_ALC_GAIN);
		        break;
	        case MeterType.LVL_G:
                val = GetTXAMeter(channel, txaMeterType.TXA_LVLR_GAIN);
		        break;
	        case MeterType.MIC_PK:
                val = GetTXAMeter(channel, txaMeterType.TXA_MIC_PK);
		        break;
	        case MeterType.ALC_PK:
                val = GetTXAMeter(channel, txaMeterType.TXA_ALC_PK);
		        break;
	        case MeterType.EQ_PK:
                val = GetTXAMeter(channel, txaMeterType.TXA_EQ_PK);
		        break;
	        case MeterType.LEVELER_PK:
                val = GetTXAMeter(channel, txaMeterType.TXA_LVLR_PK);
		        break;
	        case MeterType.COMP_PK:
                val = GetTXAMeter(channel, txaMeterType.TXA_COMP_PK);
		        break;
	        case MeterType.CPDR_PK:
                val = GetTXAMeter(channel, txaMeterType.TXA_COMP_PK);
		        break;
	        default:
		        val = -400.0;
		        break;
	        }
	        return -(float)val;
        }

        #endregion
    }
}
